using System;
using System.Reflection;

namespace calculatricAPP
{
    public partial class Form1 : Form
    {
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
            cursor("+");
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
            input.Clear();
            input.Focus();
        }

        private void c_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)

        {
            int index = input.SelectionStart;
            if (input.Text.Length == input.SelectionStart)
                input.Text = input.Text.Remove(input.Text.Length-1); //delete from the index length-1
            
            else
            
                input.Text = input.Text.Remove(input.SelectionStart - 1,1);

                input.SelectionStart = index;
                input.Focus();


        }
        #endregion

          private void Form1_Load(object sender, EventArgs e)
          {

          }
        #region extra fucntions
        //put the value after the curser specified

        private void cursor(string value) {

            int index = input.SelectionStart;
           
            input.Text = input.Text.Insert(input.SelectionStart, value);
            input.SelectionStart = value.Length + index;
            input.Focus();


        }
        #endregion
    }
}