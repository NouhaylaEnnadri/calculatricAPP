using System;
using System.DirectoryServices;
using System.Reflection;

namespace calculatricAPP
{
    public partial class Form1 : Form
    {


        private char op ;   //where we are going to store the operator
        private string op1 = "" ;   //the first variable to be entered
        private string op2 ="";    //the second var to be entered
        int result;                 // the result of the operation 

        public Form1()
        {
            InitializeComponent();
        }

        #region operation methods

        private void div_button_Click(object sender, EventArgs e)
        {
            op = '/';
            op1 = Input.Text;
            Input.Clear();  // clear the input so we can store the op2
            resultLabel.Text = op1 + op;   //where we are going to print the result
           
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            op = '-';
            op1 = Input.Text;
            Input.Text = "";
            resultLabel.Text = op1 + op;
        }

        private void mul_button_Click(object sender, EventArgs e)
        {
            op = 'x';
            op1 = Input.Text;
            Input.Text = "";
            resultLabel.Text = op1 + op;
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            op = '+';
            op1 = Input.Text;
            Input.Text = "";
            resultLabel.Text = op1 + op;
           

        }

        private void equal_btn_Click(object sender, EventArgs e)
        {

            op2 = Input.Text;     
            result  =   Calculation(op1, op, op2); 
            Input.Text = result.ToString();     //converting the intiger to string then printing it in the input
            resultLabel .Text = op1 + op + op2 + '='; // printing the operation 
          
            op = '\0';      // clearing the operator so we can store the next one
            result = 0;
            op1 = "";
            op2 = "";
          

        }
        
        #endregion

        #region numbers

        private void btn_0_Click(object sender, EventArgs e)
        {
            cursor("0");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            cursor("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            
            cursor("2"); 
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            cursor("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            cursor("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            cursor("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            cursor("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            cursor("7");
        }

        private void bnt_8_Click(object sender, EventArgs e)
        {
            cursor("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            cursor("9");
        }
        #endregion

        #region del_ce methods
        private void CE_btn_Click(object sender, EventArgs e)
        {
            Input.Clear();
            Input.Focus();
        }

        private void c_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)

        {
            int index = Input.SelectionStart;
            if (Input.Text.Length == Input.SelectionStart) // if the index is at the end of the string
                Input.Text = Input.Text.Remove(Input.Text.Length-1); //delete the last char
            
            else
            
                Input.Text = Input.Text.Remove(Input.SelectionStart - 1,1); //delete one char after the cursor position

                Input.SelectionStart = index; // put the index back to it's initial position
                Input.Focus();


        }
        #endregion

          private void Form1_Load(object sender, EventArgs e)
          {

          }
        #region extra fucntions
        //put the value after the curser specified

        private void cursor(string value) {

            int index = Input.SelectionStart;  //storing the position of the index
           
            Input.Text = Input.Text.Insert(Input.SelectionStart, value); //inserting the value entered in the index position 
            Input.SelectionStart = value.Length + index; // adding the length of the new value to increment the index position for the next entry  
            Input.Focus(); 



        }
        
        private int Calculation(string op1, char op,string  op2)
        {
            switch (op)
            {

                case '+':
                    return int.Parse(op1) + int.Parse(op2);
                case 'x':
                    return int.Parse(op1) * int.Parse(op2);
                case '-':
                    return int.Parse(op1) - int.Parse(op2);
                case '/':
                    return int.Parse(op1) / int.Parse(op2);
                    default:  return 0; 
                    break; 
            }
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}