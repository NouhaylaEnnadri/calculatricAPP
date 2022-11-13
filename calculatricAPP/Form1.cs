using System;
using System.Reflection;

namespace calculatricAPP
{
    public partial class Form1 : Form
    {

/*
        private char op ; 
        private string op1 = "" ;
        private string op2 ="";
        int result; */

        public Form1()
        {
            InitializeComponent();
        }

        #region operation methods

        private void div_button_Click(object sender, EventArgs e)
        {
            cursor("/");
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            cursor("-");
        }

        private void mul_button_Click(object sender, EventArgs e)
        {
            cursor("x");
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
          

        }

        private void equal_btn_Click(object sender, EventArgs e)
        {

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
            if (Input.Text.Length == Input.SelectionStart)
                Input.Text = Input.Text.Remove(Input.Text.Length-1); //delete from the index length-1
            
            else
            
                Input.Text = Input.Text.Remove(Input.SelectionStart - 1,1);

                Input.SelectionStart = index;
                Input.Focus();


        }
        #endregion

          private void Form1_Load(object sender, EventArgs e)
          {

          }
        #region extra fucntions
        //put the value after the curser specified

        private void cursor(string value) {

            int index = Input.SelectionStart;
           
            Input.Text = Input.Text.Insert(Input.SelectionStart, value);
            Input.SelectionStart = value.Length + index;
            Input.Focus();


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