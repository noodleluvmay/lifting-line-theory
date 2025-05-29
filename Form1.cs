using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lifting_line_NL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_bt_Click(object sender, EventArgs e)
        {
            decimal d; // for checking if values entered are numerical

            // Check if fields all have values, if not, display warning message.
            if (string.IsNullOrEmpty(span_tb.Text) ||
               string.IsNullOrEmpty(root_chord_tb.Text) ||
               string.IsNullOrEmpty(taper_tb.Text) ||
               string.IsNullOrEmpty(ae_tb.Text) ||
               string.IsNullOrEmpty(a0_tb.Text) ||
               string.IsNullOrEmpty(washout_tb.Text) ||
               string.IsNullOrEmpty(alpha_tb.Text))
            {
                MessageBox.Show("Please enter a numerical value for all fields.");
            }

            // Check if fields are numerical values, if not, display warning message.
            else 
            if (!decimal.TryParse(span_tb.Text, out d) ||
               !decimal.TryParse(root_chord_tb.Text, out d) ||
               !decimal.TryParse(taper_tb.Text, out d) ||
               !decimal.TryParse(ae_tb.Text, out d) ||
               !decimal.TryParse(a0_tb.Text, out d) ||
               !decimal.TryParse(washout_tb.Text, out d) ||
               !decimal.TryParse(alpha_tb.Text, out d))
            {
                MessageBox.Show("Please enter numerical values only.");
            }

            // If all entered fields are validated, continue calculation.
            else
            {
                // Read all input values
                double b = Convert.ToDouble(span_tb.Text);
                double c_r = Convert.ToDouble(root_chord_tb.Text);
                double taper = Convert.ToDouble(taper_tb.Text);
                double ae = Convert.ToDouble(ae_tb.Text);
                double a_0l = Convert.ToDouble(a0_tb.Text);
                double washout = Convert.ToDouble(washout_tb.Text);
                double alpha = Convert.ToDouble(alpha_tb.Text);

                double c_t = c_r * taper; // Find tip chord
                double AR = 2 * b / (c_r + c_t); // Find aspect ratio

                // Define empty arrays for storing mu and phi
                double[] mus = new double[4];
                double[] phis = new double[4];

                // Define empty list for spanwise locations
                List<int> locations = new List<int>(); 

                //---- different definitions of phi for different spanwise location input----//
                if (radioButton1.Checked == true) // if selected y-coordninate
                {
                    radioButton2.Checked = false;
                    radioButton1_CheckedChanged(sender, e);

                    locations.Add(Convert.ToInt32(s1_tb.Text));
                    locations.Add(Convert.ToInt32(s2_tb.Text));
                    locations.Add(Convert.ToInt32(s3_tb.Text));
                    locations.Add(Convert.ToInt32(s4_tb.Text)); // read spanwise locations

                    for (int i = 0; i < 4; i++) // find phi values at 4 spanwise locations
                    {
                        phis[i] = findPhi(locations[i]); //in rad
                    }
                }
                
                else // if using phi location in degree
                {
                    double[] phis_deg = { 
                        Convert.ToDouble(sdeg1_tb.Text),
                        Convert.ToDouble(sdeg2_tb.Text),
                        Convert.ToDouble(sdeg3_tb.Text),
                        Convert.ToDouble(sdeg4_tb.Text)}; // read spanwise locations

                    for (int i = 0; i < 4; i++) // find phi values at 4 spanwise locations
                    {
                        phis[i] = phis_deg[i] * Math.PI / 180; //in rad
                    }
                }

                double[] lhs = new double[4]; // define empty array for storing 4 equations vector

                double[][] rhs = MatrixCreate(4, 4); // define empty matrix for storing 4 equations coefficients

                for (int i = 0; i < 4; i++) //create lhs array for 4 different phi: mu(a-a_0l)sin(phi)
                {
                    double mu = ae * (1 + (taper - 1) * Math.Cos(phis[i])) / (2 * AR * (1 + taper)); //find mu based on phi
                    mus[i] = mu;
                    if (radioButton1.Checked==true) // if selected y-coordninate (different effective aoa calc)
                    {
                        int location = locations[i]; // read previously defined spanwise locations for alpha calculation to include washout
                        lhs[i] = mu * (findAlpha(alpha, washout, location) - a_0l * Math.PI / 180) * Math.Sin(phis[i]); // use alpha that's deducted washout angle to find lhs value for each phi
                    }
                    else // if using phi location in degree (different effective aoa calc)
                    {
                        lhs[i] = mu * (findAlpha(alpha, washout, phis[i]) - a_0l * Math.PI / 180) * Math.Sin(phis[i]); // use alpha that's deducted washout angle to find lhs value for each phi
                    }
                }

                int[] coefs = { 1, 3, 5, 7 }; // define odd coeff for creating 4 simultaneous equations

                //create rhs matrix for 4 equations
                for (int i = 0; i < 4; i++) // for each row of equations
                {
                    for (int j = 0; j < 4; j++) // for each column of coeffs for A1 A3 A5 A7
                    {
                        rhs[i][j] = Math.Sin(coefs[j] * phis[i]) * (coefs[j] * mus[i] + Math.Sin(phis[i]));
                    }
                }

                double[][] irhs = MatrixInverse(rhs); // inverse rhs matrix
                double[] A_coefs = MatrixVectorProduct(irhs, lhs); // multiplying lhs with inverse rhs to find A coeffs results

                // display A coefficients to text boxes
                A1_tb.Text = A_coefs[0].ToString();
                A3_tb.Text = A_coefs[1].ToString();
                A5_tb.Text = A_coefs[2].ToString();
                A7_tb.Text = A_coefs[3].ToString();

                // lift coef with A1
                double cl = A_coefs[0] * Math.PI * AR;

                // drag coef calculated with A1 A3 A5 A7
                double cd = Math.Pow(cl, 2) * (1
                    + 3 * Math.Pow(A_coefs[1], 2) / Math.Pow(A_coefs[0], 2)
                    + 5 * Math.Pow(A_coefs[2], 2) / Math.Pow(A_coefs[0], 2)
                    + 7 * Math.Pow(A_coefs[3], 2) / Math.Pow(A_coefs[0], 2))
                    / (Math.PI * AR);

                // display lift and drag coefs tp text boxes
                cl_tb.Text = cl.ToString();
                cd_tb.Text = cd.ToString();

            }
        }

        // Find local effective alpha based on spanwise loaction
        double findAlpha(double alpha, double washout, double location) 
        {
            double alpha_s_deg;

            if (radioButton1.Checked==true) // if using y-coord spanwise location
            {
                alpha_s_deg = alpha - location * washout / Convert.ToDouble(s5_tb.Text);
            }
            else // if using angle location
            {
                alpha_s_deg = alpha - Math.Cos(location) * washout;
            }

            return alpha_s_deg * Math.PI / 180; // convert to rad
        }//

        // Coordinate transformation, find phi in rad based on y-coord spanwise location 
        double findPhi(double location)
        {
            return Math.Acos(location / Convert.ToDouble(s5_tb.Text));
        }//

        // Matrix operation methods
        #region matrix

        // #############################################################
        //                 matrix methods
        //
        // https://jamesmccaffrey.wordpress.com/2015/03/06/inverting-a-matrix-using-c/
        //
        //############################################################## 

        static double[][] MatrixCreate(int rows, int cols)

        {
            double[][] result = new double[rows][];
            for (int i = 0; i < rows; ++i)
                result[i] = new double[cols];
            return result;
        }

        static double[] MatrixVectorProduct(double[][] matrix, double[] vector)
        {
            // result of multiplying an n x m matrix by a m x 1 
            // column vector (yielding an n x 1 column vector)
            int mRows = matrix.Length; int mCols = matrix[0].Length;
            int vRows = vector.Length;
            if (mCols != vRows)
                throw new Exception("Non-conformable matrix and vector");
            double[] result = new double[mRows];
            for (int i = 0; i < mRows; ++i)
                for (int j = 0; j < mCols; ++j)
                    result[i] += matrix[i][j] * vector[j];
            return result;
        }

        static double[][] MatrixDecompose(double[][] matrix, out int[] perm, out int toggle)
        {
            // Doolittle LUP decomposition with partial pivoting.
            // rerturns: result is L (with 1s on diagonal) and U;
            // perm holds row permutations; toggle is +1 or -1 (even or odd)
            int rows = matrix.Length;
            int cols = matrix[0].Length; // assume square
            if (rows != cols)
                throw new Exception("Attempt to decompose a non-square m");

            int n = rows; // convenience

            double[][] result = MatrixDuplicate(matrix);

            perm = new int[n]; // set up row permutation result
            for (int i = 0; i < n; ++i) { perm[i] = i; }

            toggle = 1; // toggle tracks row swaps.
                        // +1 -greater-than even, -1 -greater-than odd. used by MatrixDeterminant

            for (int j = 0; j < n - 1; ++j) // each column
            {
                double colMax = Math.Abs(result[j][j]); // find largest val in col
                int pRow = j;
                //for (int i = j + 1; i less-than n; ++i)
                //{
                //  if (result[i][j] greater-than colMax)
                //  {
                //    colMax = result[i][j];
                //    pRow = i;
                //  }
                //}

                // reader Matt V needed this:
                for (int i = j + 1; i < n; ++i)
                {
                    if (Math.Abs(result[i][j]) > colMax)
                    {
                        colMax = Math.Abs(result[i][j]);
                        pRow = i;
                    }
                }
                // Not sure if this approach is needed always, or not.

                if (pRow != j) // if largest value not on pivot, swap rows
                {
                    double[] rowPtr = result[pRow];
                    result[pRow] = result[j];
                    result[j] = rowPtr;

                    int tmp = perm[pRow]; // and swap perm info
                    perm[pRow] = perm[j];
                    perm[j] = tmp;

                    toggle = -toggle; // adjust the row-swap toggle
                }

                // --------------------------------------------------
                // This part added later (not in original)
                // and replaces the 'return null' below.
                // if there is a 0 on the diagonal, find a good row
                // from i = j+1 down that doesn't have
                // a 0 in column j, and swap that good row with row j
                // --------------------------------------------------

                if (result[j][j] == 0.0)
                {
                    // find a good row to swap
                    int goodRow = -1;
                    for (int row = j + 1; row < n; ++row)
                    {
                        if (result[row][j] != 0.0)
                            goodRow = row;
                    }

                    if (goodRow == -1)
                        throw new Exception("Cannot use Doolittle's method");

                    // swap rows so 0.0 no longer on diagonal
                    double[] rowPtr = result[goodRow];
                    result[goodRow] = result[j];
                    result[j] = rowPtr;

                    int tmp = perm[goodRow]; // and swap perm info
                    perm[goodRow] = perm[j];
                    perm[j] = tmp;

                    toggle = -toggle; // adjust the row-swap toggle
                }
                // --------------------------------------------------
                // if diagonal after swap is zero . .
                //if (Math.Abs(result[j][j]) less-than 1.0E-20) 
                //  return null; // consider a throw

                for (int i = j + 1; i < n; ++i)
                {
                    result[i][j] /= result[j][j];
                    for (int k = j + 1; k < n; ++k)
                    {
                        result[i][k] -= result[i][j] * result[j][k];
                    }
                }


            } // main j column loop

            return result;
        } // MatrixDecompose

        static double[][] MatrixInverse(double[][] matrix)
        {
            int n = matrix.Length;
            double[][] result = MatrixDuplicate(matrix);

            int[] perm;
            int toggle;
            double[][] lum = MatrixDecompose(matrix, out perm, out toggle);
            if (lum == null)
                throw new Exception("Unable to compute inverse");

            double[] b = new double[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == perm[j])
                        b[j] = 1.0;
                    else
                        b[j] = 0.0;
                }

                double[] x = HelperSolve(lum, b); // 

                for (int j = 0; j < n; ++j)
                    result[j][i] = x[j];
            }
            return result;
        }

        static double[] HelperSolve(double[][] luMatrix, double[] b)
        {
            // before calling this helper, permute b using the perm array
            // from MatrixDecompose that generated luMatrix
            int n = luMatrix.Length;
            double[] x = new double[n];
            b.CopyTo(x, 0);

            for (int i = 1; i < n; ++i)
            {
                double sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= luMatrix[i][j] * x[j];
                x[i] = sum;
            }

            x[n - 1] /= luMatrix[n - 1][n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                double sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= luMatrix[i][j] * x[j];
                x[i] = sum / luMatrix[i][i];
            }

            return x;
        }

        static double[][] MatrixDuplicate(double[][] matrix)
        {
            // allocates/creates a duplicate of a matrix.
            double[][] result = MatrixCreate(matrix.Length, matrix[0].Length);
            for (int i = 0; i < matrix.Length; ++i) // copy the values
                for (int j = 0; j < matrix[i].Length; ++j)
                    result[i][j] = matrix[i][j];
            return result;
        }

        // ####################################################
        #endregion
        //

        // Exit programme
        private void exit_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//

        // Clear all calculated values
        private void clear_bt_Click(object sender, EventArgs e) 
        {
            /*
            span_tb.Text = String.Empty;
            root_chord_tb.Text = String.Empty;
            taper_tb.Text = String.Empty;
            ae_tb.Text = String.Empty;
            a0_tb.Text = String.Empty;
            washout_tb.Text = String.Empty;
            alpha_tb.Text = String.Empty;
            */
            A1_tb.Text = String.Empty;
            A3_tb.Text = String.Empty;
            A5_tb.Text = String.Empty;
            A7_tb.Text = String.Empty;
            cl_tb.Text = String.Empty;
            cd_tb.Text = String.Empty;
        }//

        // For preloading default values
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true; // default using angle spanwise location
            radioButton1_CheckedChanged(sender, e);

            // default y-coord spanwise locations
            s1_tb.Text = "1";
            s2_tb.Text = "2";
            s3_tb.Text = "4";
            s4_tb.Text = "5";
            s5_tb.Text = "6";

            // default angle spanwise locations
            sdeg1_tb.Text = "22.5";
            sdeg2_tb.Text = "45";
            sdeg3_tb.Text = "67.5";
            sdeg4_tb.Text = "90";

            //----TAPER EXAMPLE----//

            //span_tb.Text = "4.572";
            //root_chord_tb.Text = "0.726";
            //taper_tb.Text = "0.4";
            //ae_tb.Text = "6.28";
            //a0_tb.Text = "-1.2";
            //washout_tb.Text = "0";
            //alpha_tb.Text = "4";


            //----CW----//

            span_tb.Text = "9";
            root_chord_tb.Text = "1.5";
            taper_tb.Text = "1";
            ae_tb.Text = "5.93";
            a0_tb.Text = "0";
            washout_tb.Text = "0";
            alpha_tb.Text = "4";
        }//

        // Load ae and alpha zero lift for different aerofoils when commanded
        private void naca0012_bt_Click(object sender, EventArgs e)
        {
            ae_tb.Text = "5.93";
            a0_tb.Text = "0";
        }

        private void naca2412_bt_Click(object sender, EventArgs e)
        {
            ae_tb.Text = "5.72";
            a0_tb.Text = "-2.1";
        }

        private void naca4412_bt_Click(object sender, EventArgs e)
        {
            ae_tb.Text = "5.84";
            a0_tb.Text = "-3.9";
        }

        private void naca65210_bt_Click(object sender, EventArgs e)
        {
            ae_tb.Text = "6.28";
            a0_tb.Text = "-1.2";
        }//

        // Enable/Disable text fields according to 1st radio button (y-coord spanwise location)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
                s1_tb.Enabled = radioButton1.Checked;
                s2_tb.Enabled = radioButton1.Checked;
                s3_tb.Enabled = radioButton1.Checked;
                s4_tb.Enabled = radioButton1.Checked;
                s5_tb.Enabled = radioButton1.Checked;

            if (radioButton1.Checked==true) // text box changes to white when activated
            {
                s1_tb.BackColor = Color.White;
                s2_tb.BackColor = Color.White;
                s3_tb.BackColor = Color.White;
                s4_tb.BackColor = Color.White;
                s5_tb.BackColor = Color.White;
            }
            else // text box greyed out when deactivated
            {
                s1_tb.BackColor = Color.FromArgb(238, 238, 238);
                s2_tb.BackColor = Color.FromArgb(238, 238, 238);
                s3_tb.BackColor = Color.FromArgb(238, 238, 238);
                s4_tb.BackColor = Color.FromArgb(238, 238, 238);
                s5_tb.BackColor = Color.FromArgb(238, 238, 238);
            }
        }//

        // Enable/Disable text fields according to 2nd radio button (angle spanwise location)
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sdeg1_tb.Enabled = radioButton2.Checked;
            sdeg2_tb.Enabled = radioButton2.Checked;
            sdeg3_tb.Enabled = radioButton2.Checked;
            sdeg4_tb.Enabled = radioButton2.Checked;

            if (radioButton2.Checked==true) // text box changes to white when activated
            {
                sdeg1_tb.BackColor = Color.White;
                sdeg2_tb.BackColor = Color.White;
                sdeg3_tb.BackColor = Color.White;
                sdeg4_tb.BackColor = Color.White;
            }
            else // text box greyed out when deactivated
            {
                sdeg1_tb.BackColor = Color.FromArgb(238, 238, 238);
                sdeg2_tb.BackColor = Color.FromArgb(238, 238, 238);
                sdeg3_tb.BackColor = Color.FromArgb(238, 238, 238);
                sdeg4_tb.BackColor = Color.FromArgb(238, 238, 238);
            }
        }//
    }
}
