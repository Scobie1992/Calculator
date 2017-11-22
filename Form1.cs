using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Calculator
{
    /*
     * Ashley Carr
     * P305379
     * 16/10/2017
     * GUI Calculator Windows Form for Assessment 1_6
     * Revised Version for Assessment 1_7
     */

    public partial class Form1 : Form
    {
        //Creates the form and selects txtDisplay
        public Form1()
        {
            InitializeComponent();
            txtDisplay.Select();
        }

        //Adds zero to the txtDisplay
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        //Adds one to the txtDisplay
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        //Adds two to the txtDisplay
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        //Adds three to the txtDisplay
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        //Adds four to the txtDisplay
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        //Adds five to the txtDisplay
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        //Adds six to the txtDisplay
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        //Adds seven to the txtDisplay
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        //Adds eight to the txtDisplay
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        //Adds nine to the txtDisplay
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        //Adds a point to the txtDisplay
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        //Clears the txtDisplay
        //Sets the font size back to its normal size
        //Sets the back color to white for all function buttons
        private void Clear()
        {
            Font font = new Font("Century", 21.75f, FontStyle.Bold);
            btnPlus.BackColor = Color.White;
            btnMinus.BackColor = Color.White;
            btnDivide.BackColor = Color.White;
            btnMultiply.BackColor = Color.White;
            btnEquals.BackColor = Color.White;
            btnSqrt.BackColor = Color.White;
            btnCube.BackColor = Color.White;
            btnInv.BackColor = Color.White;
            btnSin.BackColor = Color.White;
            btnCos.BackColor = Color.White;
            btnTan.BackColor = Color.White;
            txtDisplay.Clear();
            txtDisplay.Font = font;
            txtDisplay.Select();
        }
        
        //Using clear Method
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
        //Keeps track of the data entered for the calculation
        //Keeps track of the result from the calculation and testing for correct input
        //Keeps track of which calculation is to be run
        double A = 0.0;
        double B = 0.0;
        double result;
        double test;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        //Checks if the input is empty or a number
        //Takes the data input and saves it as A then clears for new input 
        //Keeps track of the plus action is to be performed with a boolean check
        //Sets the back color of btnPlus to LightGreen
        //If there is no input or is not a number then an error message appears
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    A = double.Parse(txtDisplay.Text);
                    txtDisplay.Clear();
                    txtDisplay.Select();
                    plusButtonClicked = true;
                    minusButtonClicked = false;
                    divideButtonClicked = false;
                    multiplyButtonClicked = false;
                    btnPlus.BackColor = Color.LightGreen;
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Checks if the input is empty or a number
        //Takes the data input and saves it as A then clears for new input 
        //Keeps track of the minus action is to be performed with a boolean check
        //Sets the back color of btnMinus to LightGreen
        //If there is no input or is not a number then an error message appears
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    A = double.Parse(txtDisplay.Text);
                    txtDisplay.Clear();
                    txtDisplay.Select();
                    plusButtonClicked = false;
                    minusButtonClicked = true;
                    divideButtonClicked = false;
                    multiplyButtonClicked = false;
                    btnMinus.BackColor = Color.LightGreen;
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Checks if the input is empty or a number
        //Takes the data input and saves it as A then clears for new input 
        //Keeps track of the divide action is to be performed with a boolean check
        //Sets the back color of btnDivide to LightGreen
        //If there is no input or is not a number then an error message appears
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    A = double.Parse(txtDisplay.Text);
                    txtDisplay.Clear();
                    txtDisplay.Select();
                    plusButtonClicked = false;
                    minusButtonClicked = false;
                    divideButtonClicked = true;
                    multiplyButtonClicked = false;
                    btnDivide.BackColor = Color.LightGreen;
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Checks if the input is empty or a number
        //Takes the data input and saves it as A then clears for new input 
        //Keeps track of the mutliply action is to be performed with a boolean check
        //Sets the back color of btnMultiply to LightGreen
        //If there is no input or is not a number then an error message appears
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    A = double.Parse(txtDisplay.Text);
                    txtDisplay.Clear();
                    txtDisplay.Select();
                    plusButtonClicked = false;
                    minusButtonClicked = false;
                    divideButtonClicked = false;
                    multiplyButtonClicked = true;
                    btnMultiply.BackColor = Color.LightGreen;
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Sets the back color of btnEquals to LightGreen
        //Sets the back color of the basic operators to white
        //Checks if the input is empty or a number
        //Checks to see which of the operator button has been clicked by the boolean changing from false to true
        //Takes the data input and saves it as B 
        //Runs the calculation relavent to the operator that has been clicked
        //Using the Arithmetic library the methods runs the given calculation
        //Except for dividing by zero which changes the error message
        //If there is no input or is not a number then an error message appears
        //If error is blank displays the result
        //If error is not blank then displays the error 
        //Changes first input A to is default value
        private void btnEquals_Click(object sender, EventArgs e)
        {
            string error = "";
            Font font = new Font("Century", 12.0f, FontStyle.Bold);
            btnEquals.BackColor = Color.LightGreen;
            btnPlus.BackColor = Color.White;
            btnMinus.BackColor = Color.White;
            btnDivide.BackColor = Color.White;
            btnMultiply.BackColor = Color.White;
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    if (plusButtonClicked == true)
                    {
                        B = double.Parse(txtDisplay.Text);
                        result = Arithmetic.Basic.Add(A, B);
                    }
                    else if (minusButtonClicked == true)
                    {
                        B = double.Parse(txtDisplay.Text);
                        result = Arithmetic.Basic.Sub(A, B);
                    }
                    else if (divideButtonClicked == true)
                    {
                        B = double.Parse(txtDisplay.Text);
                        if (B == 0)
                        {
                            error = "Cannot Divide by Zero";
                        }
                        else
                        {
                            result = Arithmetic.Basic.Div(A, B);
                        }
                    }
                    else if (multiplyButtonClicked == true)
                    {
                        B = double.Parse(txtDisplay.Text);
                        result = Arithmetic.Basic.Mult(A, B);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
            if (error == "")
            {
                txtDisplay.Text = result.ToString();
            }
            else
            {
                txtDisplay.Font = font;
                txtDisplay.Text = error;
            }
            A = 0.0;

        }

        //Checks if the input is empty or a number
        //Sets the back color of btnSqrt to LightGreen
        //Parses the txtDisplay to a double value and checks to see if it is positive
        //If it is greater than zero runs the SquareRoot method and sets the txtDisplay to the result
        //If it is less than zero the txtDisplay shows an error message
        //If there is no input or is not a number then an error message appears
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            Font font = new Font("Century", 12.0f, FontStyle.Bold);
            btnSqrt.BackColor = Color.LightGreen;
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    double num = double.Parse(txtDisplay.Text);
                    if (num >= 0)
                    {
                        txtDisplay.Text = SquareRoot(num).ToString();
                    }
                    else
                    {
                        txtDisplay.Font = font;
                        txtDisplay.Text = "Number must be positive";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Take in the value to be squared and makes use of the Algebraic library method SquareRoot
        //Double value is taken in as well a reutrned back out
        private double SquareRoot(double x)
        {
            double sqrt = Algebraic.Power.SquareRoot(x);
            return sqrt;
        }

        //Checks if the input is empty or a number
        //Sets the back color of btnCube to LightGreen
        //Parses the txtDisplay to a double value and runs the CubeRoot method
        //Sets the txtDisplay to the result
        //If there is no input or is not a number then an error message appears
        private void btnCube_Click(object sender, EventArgs e)
        {
            btnCube.BackColor = Color.LightGreen;
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    double num = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = CubeRoot(num).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Take in the value to be cubed and makes use of the Algebraic library method CubeRoot
        //Double value is taken in as well a reutrned back out
        private double CubeRoot(double y)
        {
            double cube = Algebraic.Power.CubeRoot(y);
            return cube;
        }

        //Checks if the input is empty or a number
        //Sets the back color of btnInv to LightGreen
        //Parses the txtDisplay to a double value and checks to see if it is zero
        //If it is zero then the txtDisplay shows an error message
        //If it is not zero runs the Inverse method and sets the txtDisplay to the result
        //If there is no input or is not a number then an error message appears
        private void btnInv_Click(object sender, EventArgs e)
        {
            Font font = new Font("Century", 12.0f, FontStyle.Bold);
            btnInv.BackColor = Color.LightGreen;
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    double num = double.Parse(txtDisplay.Text);
                    if (num == 0)
                    {
                        txtDisplay.Font = font;
                        txtDisplay.Text = "Cannot Divide by Zero";
                    }
                    else
                    {
                        txtDisplay.Text = Inverse(num).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Take in the value to be inversed and makes use of the Algebraic library method Inverse
        //Double value is taken in as well a reutrned back out
        private double Inverse(double i)
        {
            double inv = Algebraic.Power.Inverse(i);
            return inv;
        }

        //Checks if the input is empty or a number
        //Sets the back color of btnSin to LightGreen
        //Parses the txtDisplay to a double value and runs the Sine method
        //Sets the txtDisplay to the result
        //If there is no input or is not a number then an error message appears
        private void btnSin_Click(object sender, EventArgs e)
        {
            btnSin.BackColor = Color.LightGreen;
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    double num = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = Sine(num).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Take in the value to find the sine and makes use of the Trigonometric library method Sine
        //Double value is taken in as well a reutrned back out
        private double Sine(double s)
        {
            double sine = Trigonometric.Angle.Sine(s);
            return sine;
        }

        //Checks if the input is empty or a number
        //Sets the back color of btnCos to LightGreen
        //Parses the txtDisplay to a double value and runs the Cosine method
        //Sets the txtDisplay to the result
        //If there is no input or is not a number then an error message appears
        private void btnCos_Click(object sender, EventArgs e)
        {
            btnCos.BackColor = Color.LightGreen;
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    double num = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = Cosine(num).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Take in the value to find the cosine and makes use of the Trigonometric library method Cosine
        //Double value is taken in as well a reutrned back out
        private double Cosine(double c)
        {
            double cosine = Trigonometric.Angle.Cosine(c);
            return cosine;
        }

        //Checks if the input is empty or a number
        //Sets the back color of btnTan to LightGreen
        //Parses the txtDisplay to a double value and runs the Tangent method
        //Sets the resultTangent to the result
        //Checks if the result is greater than 1000 or less than -1000
        //If the resultTangent is greater or less than the txtDisplay is set to an error message
        //If the resultTangent is within these values sets the txtDisplay to resultTangent
        //If there is no input or is not a number then an error message appears
        private void btnTan_Click(object sender, EventArgs e)
        {
            double resultTangent;
            btnTan.BackColor = Color.LightGreen;
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (double.TryParse(txtDisplay.Text, out test) == true)
                {
                    double num = double.Parse(txtDisplay.Text);
                    resultTangent = Tangent(num); 
                    if (resultTangent > 1000 || resultTangent < -1000)
                    {
                        txtDisplay.Text = "Invalid Input";
                    }
                    else
                    {
                        txtDisplay.Text = resultTangent.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Number", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Error no input", "Error Message");
            }
        }

        //Take in the value to find the tangent and makes use of the Trigonometric library method Tangent
        //Double value is taken in as well a reutrned back out
        private double Tangent(double t)
        {
            double tangent = Trigonometric.Angle.Tangent(t);
            return tangent;
        }

        //Quit option in the toolStripMenu with a MessageBox 
        //Checks if the user really wants to quit the application
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) ==
                DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Clear option in the toolStripMenu using clear method
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
