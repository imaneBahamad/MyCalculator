using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetResult()
        {
            result.Text = "0";
        }

        private void button_one_Click(object sender, EventArgs e)
        {
            resetResult();

            if(insert.Text == "0")
                insert.Text = "1";
            else
                insert.Text += "1";
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "2";
            else
                insert.Text += "2";
        }

        private void button_three_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "3";
            else
                insert.Text += "3";
        }

        private void button_four_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "4";
            else
                insert.Text += "4";
        }

        private void button_five_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "5";
            else
                insert.Text += "5";
        }

        private void button_six_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "6";
            else
                insert.Text += "6";
        }

        private void button_seven_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "7";
            else
                insert.Text += "7";
        }

        private void button_eight_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "8";
            else
                insert.Text += "8";
        }

        private void button_nine_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "9";
            else
                insert.Text += "9";
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            resetResult();

            if (insert.Text == "0")
                insert.Text = "0";
            else
                insert.Text += "0";
        }


        private void button_C_Click(object sender, EventArgs e)
        {
            insert.Text = "0";
            resetResult();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            resetResult();

            string expression = insert.Text;
            string newExpression = "";
            for (int i=0; i < expression.Length-1; i++){
                newExpression += expression[i];
            }
            if (newExpression.Length >= 1)
                insert.Text = newExpression;
            else
                insert.Text = "0";           
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            resetResult();
            insert.Text += ".";
        }

        private void button_parentheses_Click(object sender, EventArgs e)
        {
            resetResult();
            if (insert.Text == "0")
                insert.Text = "(";
            else
                insert.Text += "(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetResult();
            if (insert.Text == "0")
                insert.Text = ")";
            else
                insert.Text += ")";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            resetResult();

            string res = insert.Text;
            char[] op = { '+', '*', '-', '/', '%' };
            if (!Array.Exists(op, element => element == res[res.Length - 1]) && res!="0")
            {
                insert.Text += "+";
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            resetResult();

            string res = insert.Text;
            char[] op = { '+', '*', '-', '/', '%' };
            if (!Array.Exists(op,element => element == res[res.Length - 1]))
            {
                if (insert.Text == "0")
                    insert.Text = "-";
                else
                    insert.Text += "-";
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            resetResult();

            string res = insert.Text;
            char[] op = { '+', '*', '-', '/', '%' };
            if (!Array.Exists(op, element => element == res[res.Length - 1]) && res != "0")
            {
                insert.Text += "*";
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            resetResult();

            string res = insert.Text;
            char[] op = { '+', '*', '-', '/', '%' };
            if (!Array.Exists(op, element => element == res[res.Length - 1]) && res != "0")
            {
                insert.Text += "/";
            }
        }

        private void button_modulo_Click(object sender, EventArgs e)
        {
            resetResult();

            string res = insert.Text;
            char[] op = { '+', '*', '-', '/', '%' };
            if (!Array.Exists(op, element => element == res[res.Length - 1]))
            {
                insert.Text += "%";
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            string expression = insert.Text;
            /*char[] op = { '+', '*', '-', '/', '%' };
            string[] resSplit;
            double res = 0;*/

            DataTable dataTable;
            DataRow row;
            try
            {
                dataTable = new DataTable();
                dataTable.Columns.Add(columnName: "expression", typeof(string), expression);
                row = dataTable.NewRow();
                dataTable.Rows.Add(row);

                result.Text = (string)row["expression"];
            }catch(DivideByZeroException exp)
            {
                result.Text = "Can't divide by 0";
            }
            catch(Exception exp)
            {
                result.Text = "Error";
            }
            

            /*for (int i = 0; i < op.Length; i++)
            {
                if (expression.Contains(op[i]))
                {
                    resSplit = expression.Split(op[i]);
                    switch (op[i])
                    {
                        case '+':
                            res = Convert.ToDouble(resSplit[0]) + Convert.ToDouble(resSplit[1]);
                            break;
                        case '-':
                            res = Convert.ToDouble(resSplit[0]) - Convert.ToDouble(resSplit[1]);
                            break;
                        case '*':
                            res = Convert.ToDouble(resSplit[0]) * Convert.ToDouble(resSplit[1]);
                            break;
                        case '/':
                            res = Convert.ToDouble(resSplit[0]) / Convert.ToDouble(resSplit[1]);
                            break;
                        case '%':
                            res = Convert.ToDouble(resSplit[0]) % Convert.ToDouble(resSplit[1]);
                            break;
                    }
                    result.Text = res + "";
                }
            }*/



        }
    }
}
