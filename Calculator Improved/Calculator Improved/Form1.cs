using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Improved
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calculo = "";
        string num1 = "";
        string num2 = "";
        int num3 = 1;
        int num4 = 1;
        double num5 = 0;
        double num6 = 0;
        double result = 0;
        bool sqrt = false;
        bool power = false;
        bool add = false;
        bool remove = false;
        bool multiply = false;
        bool divide = false;
        bool justadded = false;
        bool justremoved = false;
        bool justmultiplied = false;
        bool justdivided = false;
        bool period1 = false;
        bool period2 = false; 
        bool onlyperiod = false;
        

        


        private void zero_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000)
            {
                calculo += "0";
                operation.Text = calculo;
                num1 += "0";
                num3 *= 10;
                onlyperiod = true;
            }
            else if (calculo != "" && add == true | remove == true | multiply == true | divide == true &&
                      num4 < 1000000 && power == false)  
            {
                calculo += "0";
                operation.Text = calculo;
                num2 += "0";
                num4 *= 10;
            }
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000)
            {
                calculo += "1";
                operation.Text = calculo;
                num1 += "1";
                num3 *= 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false)  
            {
                calculo += "1";
                operation.Text = calculo;
                num2 += "1";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000 && onlyperiod == false)
            {
                calculo += "2";
                operation.Text = calculo;
                num1 += "2";
                num3 += 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false && onlyperiod == false)  
            {
                calculo += "2";
                operation.Text = calculo;
                num2 += "2";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000 && onlyperiod == false)
            {
                calculo += "3";
                operation.Text = calculo;
                num1 += "3";
                num3 *= 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false && onlyperiod == false)  
            {
                calculo += "3";
                operation.Text = calculo;
                num2 += "3";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000 && onlyperiod == false)
            {
                calculo += "4";
                operation.Text = calculo;
                num1 += "4";
                num3 *= 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false && onlyperiod == false)  
            {
                calculo += "4";
                operation.Text = calculo;
                num2 += "4";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000 && onlyperiod == false)
            {
                calculo += "5";
                operation.Text = calculo;
                num1 += "5";
                num3 *= 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false && onlyperiod == false)  
            {
                calculo += "5";
                operation.Text = calculo;
                num2 += "5";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000 && onlyperiod == false)
            {
                calculo += "6";
                operation.Text = calculo;
                num1 += "6";
                num3 *= 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false && onlyperiod == false)  
            {
                calculo += "6";
                operation.Text = calculo;
                num2 += "6";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000 && onlyperiod == false)
            {
                calculo += "7";
                operation.Text = calculo;
                num1 += "7";
                num3 *= 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false && onlyperiod == false)  
            {
                calculo += "7";
                operation.Text = calculo;
                num2 += "7";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000 && onlyperiod == false)
            {
                calculo += "8";
                operation.Text = calculo;
                num1 += "8";
                num3 *= 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false && onlyperiod == false)  
            {
                calculo += "8";
                operation.Text = calculo;
                num2 += "8";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && num3 < 1000000 && onlyperiod == false)
            {
                calculo += "9";
                operation.Text = calculo;
                num1 += "9";
                num3 *= 10;
            }
            else if (add == true | remove == true | multiply == true | divide == true && num4 < 1000000 && power == false && onlyperiod == false)  
            {
                calculo += "9";
                operation.Text = calculo;
                num2 += "9";
                justadded = false;
                justremoved = false;
                justmultiplied = false;
                justdivided = false;
                num4 *= 10;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (add == true && num2 != "")
            {
                result = Convert.ToDouble(num1, CultureInfo.InvariantCulture) + Convert.ToDouble(num2, CultureInfo.InvariantCulture);
                operation.Text = Convert.ToString(result, CultureInfo.InvariantCulture);
                num2 = "";
                num3 = 0;
                num4 = 0;
                num1 = Convert.ToString(result, CultureInfo.InvariantCulture);
                result = 0;
                add = false;
                remove = false;
                multiply = false;
                divide = false;
                power = false;
                sqrt = false;
                period1 = false;
                period2 = false;
            }
            
            if (remove == true && num2 != "")
            {
                result = Convert.ToDouble(num1, CultureInfo.InvariantCulture) - Convert.ToDouble(num2, CultureInfo.InvariantCulture);
                operation.Text = Convert.ToString(result, CultureInfo.InvariantCulture);
                num2 = "";
                num3 = 0;
                num4 = 0;
                num1 = Convert.ToString(result, CultureInfo.InvariantCulture);
                result = 0;
                add = false;
                remove = false;
                multiply = false;
                divide = false;
                power = false;
                sqrt = false;
                period1 = false;
                period2 = false;
            }
            
            if (multiply == true && num2 != "")
            {
                result = Convert.ToDouble(num1, CultureInfo.InvariantCulture) * Convert.ToDouble(num2, CultureInfo.InvariantCulture);
                operation.Text = Convert.ToString(result, CultureInfo.InvariantCulture);
                num2 = "";
                num3 = 0;
                num4 = 0;
                num1 = Convert.ToString(result, CultureInfo.InvariantCulture);
                result = 0;
                add = false;
                remove = false;
                multiply = false;
                divide = false;
                power = false;
                sqrt = false;
                period1 = false;
                period2 = false;
            }
            
            if (divide == true && num2 != "")
            {
                result = Convert.ToDouble(num1, CultureInfo.InvariantCulture) / Convert.ToDouble(num2, CultureInfo.InvariantCulture);
                operation.Text = Convert.ToString(result, CultureInfo.InvariantCulture);
                num2 = "";
                num3 = 0;
                num4 = 0;
                num1 = Convert.ToString(result, CultureInfo.InvariantCulture);
                result = 0;
                add = false;
                remove = false;
                multiply = false;
                divide = false;
                power = false;
                sqrt = false;
                period1 = false;
                period2 = false;
            }

            if (power == true)
            {
                result = Convert.ToDouble(num1, CultureInfo.InvariantCulture) * Convert.ToDouble(num1, CultureInfo.InvariantCulture);
                operation.Text = Convert.ToString(result, CultureInfo.InvariantCulture);
                num2 = "";
                num3 = 0;
                num4 = 0;
                num1 = Convert.ToString(result, CultureInfo.InvariantCulture);
                result = 0;
                add = false;
                remove = false;
                multiply = false;
                divide = false;
                power = false;
                sqrt = false;
                period1 = false;
                period2 = false;
            }

            if (sqrt == true)
            {
                result = Convert.ToDouble(Math.Sqrt(Convert.ToDouble(num1, CultureInfo.InvariantCulture)));
                operation.Text = Convert.ToString(result, CultureInfo.InvariantCulture);
                num2 = "";
                num3 = 0;
                num4 = 0;
                num1 = Convert.ToString(result, CultureInfo.InvariantCulture);
                result = 0;
                add = false;
                remove = false;
                multiply = false;
                divide = false;
                power = false;
                sqrt = false;
                period1 = false;
                period2 = false;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && power == false && sqrt == false && calculo != "")
            {
                calculo += " + ";
                operation.Text = calculo;
                add = true;
                justadded = true;
                onlyperiod = false;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && power == false && sqrt == false && calculo != "")
            {
                calculo += " - ";
                operation.Text = calculo;
                remove = true;
                justremoved = true;
                onlyperiod = false;
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && power == false && sqrt == false && calculo != "")
            {
                calculo += " x ";
                operation.Text = calculo;
                multiply = true;
                justmultiplied = true;
                onlyperiod = false;
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && power == false && sqrt == false && calculo != "")
            {
                calculo += " ÷ ";
                operation.Text = calculo;
                divide = true;
                justdivided = true;
                onlyperiod = false;
            }
        }

        private void root_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && power == false && sqrt == false &&
                calculo == "")
            {
                calculo += "²√";
                operation.Text = calculo;
                sqrt = true;
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && power == false && sqrt == false &&
                calculo != "")
            {
                calculo += "²";
                operation.Text = calculo;
                power = true;
                onlyperiod = false;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            calculo = "";
            operation.Text = calculo;
            num1 = "";
            num2 = "";
            num3 = 1;
            num4 = 1;
            num5 = 0;
            num6 = 0;
            add = false;
            remove = false;
            multiply = false;
            divide = false;
            power = false;
            sqrt = false;
            period1 = false;
            period2 = false;
            onlyperiod = false;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            // este es el único comentario que me dieron ganas de dejar ²
        }


        private void dot_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && power == false && period1 == false && num1 != "")
            {
                calculo += ".";
                operation.Text = calculo;
                num1 += ".";
                period1 = true;
                onlyperiod = false;
            }

            if (add == true | remove == true | multiply == true | divide == true && power == false && period2 == false && num2 != "")
            {
                calculo += ".";
                operation.Text = calculo;
                num2 += ".";
                period2 = true;
                onlyperiod = false;
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (add == false && remove == false && multiply == false && divide == false && power == false &&
                sqrt == false && calculo != "")
            {
                num5 = num5 + Convert.ToDouble(num1);
                num5 *= -1;
                num1 = Convert.ToString(num5, CultureInfo.InvariantCulture);
                calculo = num1;
                operation.Text = calculo;
            }

            if (add == true && num2 != "")
            {
                num6 = num6 + Convert.ToDouble(num2);
                num6 *= -1;
                num2 = Convert.ToString(num6, CultureInfo.InvariantCulture);
                calculo = num1 + " + " + num2;
                operation.Text = calculo;
            }
            
            if (remove == true && num2 != "")
            {
                num6 = num6 + Convert.ToDouble(num2);
                num6 *= -1;
                num2 = Convert.ToString(num6, CultureInfo.InvariantCulture);
                calculo = num1 + " - " + num2;
                operation.Text = calculo;
            }
            
            if (multiply == true && num2 != "")
            {
                num6 = num6 + Convert.ToDouble(num2);
                num6 *= -1;
                num2 = Convert.ToString(num6, CultureInfo.InvariantCulture);
                calculo = num1 + " x " + num2;
                operation.Text = calculo;
            }
            
            if (divide == true && num2 != "")
            {
                num6 = num6 + Convert.ToDouble(num2);
                num6 *= -1;
                num2 = Convert.ToString(num6, CultureInfo.InvariantCulture);
                calculo = num1 + " ÷ " + num2;
                operation.Text = calculo;
            }
        }
    }
}