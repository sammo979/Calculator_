using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double total = 0;
        double[] numbers = new double[50];
        double[] done = new double[50];
        string[] math = new string[50];
        int count = 0;
        bool StartEntry = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            KeyPress += Calculator_KeyPress;
        }
        void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                //Zero
                case 48:
                    Zero_Click(Zero, new EventArgs());
                    break;
                //One
                case 49:
                    One_Click(One, new EventArgs());
                    break;
                //Two
                case 50:
                    Two_Click(Two, new EventArgs());
                    break;
                //Three
                case 51:
                    Three_Click(Three, new EventArgs());
                    break;
                //Four
                case 52:
                    Four_Click(Four, new EventArgs());
                    break;
                //Five
                case 53:
                    Five_Click(Five, new EventArgs());
                    break;
                //Six
                case 54:
                    Six_Click(Six, new EventArgs());
                    break;
                //Seven
                case 55:
                    Seven_Click(Seven, new EventArgs());
                    break;
                //Eight
                case 56:
                    Eight_Click(Eight, new EventArgs());
                    break;
                //Nine
                case 57:
                    Nine_Click(Nine, new EventArgs());
                    break;
                //Plus
                case 43:
                    Addition_Click(Addition, new EventArgs());
                    break;
                //Minus
                case 45:
                    Subtract_Click(Subtract, new EventArgs());
                    break;
                //Times
                case 42:
                    mulitiply_Click(mulitiply, new EventArgs());
                    break;
                //divide
                case 47:
                    Divided_Click(Divided, new EventArgs());
                    break;
                //XSqaured
                case 94:
                    XSquared_Click(XSquared, new EventArgs());
                    break;
                //equal
                case 61:
                    Equal_Click(Equal, new EventArgs());
                    break;
                //decimal
                case 46:
                    Decimal_Click(Decimal, new EventArgs());
                    break;
            }
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            Input.Text += "0";
        }
        private void One_Click(object sender, EventArgs e)
        {
            Input.Text += "1";
        }
        private void Two_Click(object sender, EventArgs e)
        {
            Input.Text += "2";
        }
        private void Three_Click(object sender, EventArgs e)
        {
            Input.Text += "3";
        }
        private void Four_Click(object sender, EventArgs e)
        {
            Input.Text += "4";
        }
        private void Five_Click(object sender, EventArgs e)
        {
            Input.Text += "5";
        }
        private void Six_Click(object sender, EventArgs e)
        {
            Input.Text += "6";
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            Input.Text += "7";
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            Input.Text += "8";
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            Input.Text += "9";
        }
        private void XSquaredOfY_Click(object sender, EventArgs e)
        {
            if (StartEntry == true)// clears the history if there was a previous entry
            {
                Results.Text = "";
                StartEntry = false;
            }
            //total = double.Parse(Input.Text);
            Results.Text += Input.Text + "^";
            numbers[count] = double.Parse(Input.Text);
            count++;
            math[count] = "^y";
            Input.Text = "";
        }
        private void Addition_Click(object sender, EventArgs e)
        {
            // this clears the history if there was a previous entry
            if (StartEntry == true)
            {
                Results.Text = "";
                StartEntry = false;
            }
            Results.Text += Input.Text + "+";
            if (Input.Text != "")//if input is not empty
            {
                numbers[count] = double.Parse(Input.Text);
            }
            count++;
            math[count] = "+";
            Input.Text = "";
        }
        private void Subtract_Click(object sender, EventArgs e)
        {
            if (StartEntry == true)// this clears the history if there was a previous entry
            {
                Results.Text = "";
                StartEntry = false;
            }
            Results.Text += Input.Text + "-";
            if (Input.Text != "")//if input is not empty
            {
                numbers[count] = double.Parse(Input.Text);
            } 
            count++;
            math[count] = "-";
            Input.Text = "";
        }
        private void mulitiply_Click(object sender, EventArgs e)
        {
            if (StartEntry == true)// this clears the history if there was a previous entry
            {
                Results.Text = "";
                StartEntry = false;
            }
            Results.Text += Input.Text + "X";
            if (Input.Text != "")//if input is not empty
            {
                numbers[count] = double.Parse(Input.Text);
            } 
            count++;
            math[count] = "X";
            Input.Text = "";
        }
        private void Decimal_Click(object sender, EventArgs e)
        {
            Input.Text += ".";
        }
        private void Divided_Click(object sender, EventArgs e)
        {
            if (StartEntry == true) // this clears the history if there was a previous entry
            {
                Results.Text = "";
                StartEntry = false;
            }
            Results.Text += Input.Text + "/";
            if (Input.Text != "") //if input is not empty
            {
                numbers[count] = double.Parse(Input.Text);
                
            }
            count++;
            math[count] = "/";
            Input.Text = "";
        }
        private void XSquared_Click(object sender, EventArgs e)
        {
            if (StartEntry == true)// this clears the history if there was a previous entry
            {
                Results.Text = "";
                StartEntry = false;
            }
            Results.Text += Input.Text + "^2";
            numbers[count] = double.Parse(Input.Text);
            count++;
            math[count] = "^";
            Input.Text = "";
        }
        private void OneOverX_Click(object sender, EventArgs e)
        {
            if (StartEntry == true)// this clears the history if there was a previous entry
            {
                Results.Text = "";
                StartEntry = false;
            }
            Results.Text += 1 + "/" + Input.Text;
            numbers[count] = 1;
            count++;
            math[count] = "/";
            numbers[count] = double.Parse(Input.Text);
            count++;
            Input.Text = "";
        }
        private void PostiveNegative_Click(object sender, EventArgs e)
        {
            if (StartEntry == true)// this clears the history if there was a previous entry
            {
                Results.Text = "";
                StartEntry = false;
            }
            total = double.Parse(Input.Text);
            double temp = total * -1;
            numbers[count] = temp;
            Results.Text += temp.ToString();
            count++;
            Input.Text = "";
        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (StartEntry == true)// this clears the history if there was a previous entry
            {
                Results.Text = "";
                StartEntry = false;
            }
            Results.Text = "√" + Input.Text;
            numbers[count] = double.Parse(Input.Text);
            count++;
            math[count] = "√";
            Input.Text = "";
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            int num = 0;
            int check = 0;
            int ready = 0;
            int ready2 = 0;
            int x = 0;
            if (Input.Text != "")//if input is not empty
            {
                numbers[count] = double.Parse(Input.Text);
            }
            //exponents
            while (check == 0)
            {
                //find the exponents
                for (int i = 0; i < math.Length; i++)
                {
                    if (math[i] == "^" || math[i] == "^y")
                    {
                        num = i;
                        break;
                    }
                }
                if (math[num] == "^")//^2 
                {
                    // do the math, then check if there is anymore
                    double base1 = numbers[num - 1];
                    total = base1;
                    for (x = 0; x < 1; x++)
                    {
                        total = total * base1;
                    }
                    math[num] = null;
                    numbers[num - 1] = total;
                    numbers[num] = 0;
                    done[num] = 1;
                }
                else if (math[num] == "^y")
                {
                    double base1 = numbers[num - 1];
                    total = base1;
                    for (x = 0; x < (numbers[num] - 1); x++)
                    {
                        total *= base1;
                    }
                    math[num] = null;
                    numbers[num] = total;
                    done[num - 1] = 1;
                    numbers[num - 1] = 0;
                    done[num] = 0;
                }
                else
                {
                    check++;
                }
            }
            check = 0;
            //square roots
            while (check == 0)
            {
                //find the square roots
                for (int i = 0; i < math.Length; i++)
                {
                    if (math[i] == "√")
                    {
                        num = i;
                        break;
                    }
                }
                if (math[num] == "√")
                {

                    // do the math, then check if there is anymore
                    //first check if there are two number next to each other
                    if (done[num] == 1)
                    {
                        if (done[num - 1] != 1)
                        {
                            numbers[num] = numbers[num - 1];
                            done[num] = 0;
                            done[num - 1] = 1;

                        }
                        else if (done[num + 1] != 1)
                        {
                            numbers[num] = numbers[num + 1];
                            done[num] = 0;
                            done[num + 1] = 1;
                        }
                        ready = 1;
                    }
                    if (num + 1 <= 49)
                    {
                        if (done[num + 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (done[num + x] == 0)
                                {
                                    break;
                                }
                            }
                            numbers[num + 1] = numbers[num + x];
                            numbers[num + x] = 0;
                            done[num + x] = 1;
                            done[num + 1] = 0;
                        }
                    }
                    if (num - 1 >= 0)
                    {
                        if (done[num - 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (num - x >= 0)
                                {
                                    if (done[num - x] == 0)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (num - x >= 0)
                            {
                                numbers[num - 1] = numbers[num - x];
                                numbers[num - x] = 0;
                                done[num - x] = 1;
                                done[num - 1] = 0;
                            }
                        }
                    }
                    if (ready != 1)
                    {
                        total = Math.Sqrt(numbers[num - 1]);
                        done[num - 1] = 1;
                        numbers[num - 1] = 0;
                        numbers[num] = total;
                    }
                    else if (ready == 1)
                    {
                        total = Math.Sqrt(numbers[num + 1]);
                        done[num] = 1;
                        numbers[num] = 0;
                        numbers[num + 1] = total;
                    }
                    math[num] = null;
                }
                else
                {
                    check++;
                }
                ready = 0;
            }
            check = 0;
            //mulitiply
            while (check == 0)
            {
                //find the multiplcation 
                for (int i = 0; i < math.Length; i++)
                {
                    if (math[i] == "X")
                    {
                        num = i;
                        break;
                    }
                }
                if (math[num] == "X")
                {

                    // do the math, then check if there is anymore
                    //first check if there are two number next to each other
                    if (done[num] == 1)
                    {
                        if (done[num - 1] != 1)
                        {
                            numbers[num] = numbers[num - 1];
                            done[num] = 0;
                            done[num - 1] = 1;
                            numbers[num - 1] = 0;

                        }
                        else if (done[num + 1] != 1)
                        {
                            numbers[num] = numbers[num + 1];
                            done[num] = 0;
                            done[num + 1] = 1;
                            numbers[num + 1] = 0;
                        }
                        ready = 1;
                    }
                    if (num + 1 <= 49)
                    {
                        if (done[num + 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (done[num + x] == 0)
                                {
                                    break;
                                }
                            }
                            numbers[num + 1] = numbers[num + x];
                            numbers[num + x] = 0;
                            done[num + x] = 1;
                            done[num + 1] = 0;
                        }
                        else
                        {
                            ready2 = 0;
                        }
                    }
                    if (num - 1 >= 0 && ready2 != 1)
                    {
                        if (done[num - 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (num - x >= 0)
                                {
                                    if (done[num - x] == 0)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (num - x >= 0)
                            {
                                numbers[num - 1] = numbers[num - x];
                                numbers[num - x] = 0;
                                done[num - x] = 1;
                                done[num - 1] = 0;
                            }
                        }
                    }
                    if (ready != 1)
                    {
                        total = numbers[num - 1] * numbers[num];
                        done[num - 1] = 1;
                        numbers[num - 1] = 0;
                        numbers[num] = total;
                    }
                    else if (ready == 1)
                    {
                        total = numbers[num] * numbers[num + 1];
                        done[num] = 1;
                        numbers[num] = 0;
                        numbers[num + 1] = total;
                    }
                    math[num] = null;
                }
                else 
                {
                    check++;
                }
                ready = 0;
                ready2 = 0;
            }
            check = 0;
            //divide
            while (check == 0)
            {
                //find the Divide 
                for (int i = 0; i < math.Length; i++)
                {
                    if (math[i] == "/")
                    {
                        num = i;
                        break;
                    }
                }
                if (math[num] == "/")
                {
                    // do the math, then check if there is anymore
                    //first check if there are two number next to each other
                    if (done[num] == 1)
                    {
                        if (done[num - 1] != 1)
                        {
                            numbers[num] = numbers[num - 1];
                            numbers[num - 1] = 0;
                            done[num] = 0;
                            done[num - 1] = 1;

                        }
                        else if (done[num + 1] != 1)
                        {
                            numbers[num] = numbers[num + 1];
                            done[num] = 0;
                            done[num + 1] = 1;
                            numbers[num + 1] = 0;
                        }
                        ready = 1;
                    }
                    if (num + 1 <= 49)
                    {
                        if (done[num + 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (done[num + x] == 0)
                                {
                                    break;
                                }
                            }
                            numbers[num + 1] = numbers[num + x];
                            numbers[num + x] = 0;
                            done[num + x] = 1;
                            done[num + 1] = 0;
                        }
                        else
                        {
                            ready2 = 0;
                        }
                    }
                    if (num - 1 >= 0 && ready2 != 1)
                    {
                        if (done[num - 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (num - x >= 0)
                                {
                                    if (done[num - x] == 0)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (num - x >= 0)
                            {
                                numbers[num - 1] = numbers[num - x];
                                numbers[num - x] = 0;
                                done[num - x] = 1;
                                done[num - 1] = 0;
                            }
                        }
                    }
                    if (ready != 1)
                    {
                        total = numbers[num - 1] / numbers[num];
                        done[num - 1] = 1;
                        numbers[num - 1] = 0;
                        numbers[num] = total;
                    }
                    else if (ready == 1)
                    {
                        total = numbers[num] / numbers[num + 1];
                        done[num] = 1;
                        numbers[num] = 0;
                        numbers[num + 1] = total;
                    }
                    math[num] = null;
                }
                else 
                {
                    check++;
                }
                ready = 0;
                ready2 = 0;
            }
            check = 0;
            //add
            while (check == 0)
            {
                //find the Addition 
                for (int i = 0; i < math.Length; i++)
                {
                    if (math[i] == "+")
                    {
                        num = i;
                        break;
                    }
                }
                if (math[num] == "+")
                {
                    // do the math, then check if there is anymore
                    //first check if there are two number next to each other
                    if (done[num] == 1 )// if there is not a number here
                    { 
                        if (done[num - 1] != 1)
                        {
                            numbers[num] = numbers[num - 1];
                            done[num] = 0;
                            done[num - 1] = 1;
                            numbers[num - 1] = 0;

                        }
                        else if (done[num + 1] != 1)
                        {
                            numbers[num] = numbers[num + 1];
                            done[num] = 0;
                            done[num + 1] = 1;
                            numbers[num + 1] = 0;
                        }
                        ready = 1;
                    }
                    if (num + 1 <= 49)
                    {
                        if (done[num + 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (done[num + x] == 0)
                                {
                                    break;
                                }
                            }
                            numbers[num + 1] = numbers[num + x];
                            numbers[num + x] = 0;
                            done[num + x] = 1;
                            done[num + 1] = 0;
                        }
                        else 
                        {
                            ready2 = 0;
                        }
                    }
                    if (num - 1 > 0 && ready2 != 1)
                    {
                        if (done[num - 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (num - x >= 0)
                                {
                                    if (done[num - x] == 0)
                                    {
                                        break;
                                    }
                                }
                                
                            }
                            if(num - x >= 0)
                            {
                                numbers[num - 1] = numbers[num - x];
                                numbers[num - x] = 0;
                                done[num - x] = 1;
                                done[num - 1] = 0;
                            }
                            
                        }
                    }
                    if (ready != 1)
                    {
                        total = numbers[num - 1] + numbers[num];
                        done[num - 1] = 1;
                        numbers[num - 1] = 0;
                        numbers[num] = total;
                    }
                    else if(ready == 1)
                    {
                        total = numbers[num] + numbers[num + 1];
                        done[num] = 1;
                        numbers[num] = 0;
                        numbers[num + 1] = total;
                    }
                    math[num] = null; 
                }
                else
                {
                    check++;
                }
                ready = 0;
                ready2 = 0;
            }
            check = 0;
            //subtraction
            while(check == 0)
            {
                //find the subtraction 
                for (int i = 0; i < math.Length; i++)
                {
                    if (math[i] == "-")
                    {
                        num = i;
                        break;
                    }
                }
                if (math[num] == "-")
                {
                    // do the math, then check if there is anymore
                    //first check if there are two number next to each other
                    if (done[num] == 1)
                    {
                        if (done[num - 1] != 1)
                        {
                            numbers[num] = numbers[num - 1];
                            done[num] = 0;
                            done[num - 1] = 1;
                            numbers[num - 1] = 0;

                        }
                        else if (done[num + 1] != 1)
                        {
                            numbers[num] = numbers[num + 1];
                            done[num] = 0;
                            done[num + 1] = 1;
                            numbers[num + 1] = 0;
                        }
                        ready = 1;
                    }
                    if (num + 1 <= 49)
                    {
                        if (done[num + 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (done[num + x] == 0)
                                {
                                    break;
                                }
                            }
                            numbers[num + 1] = numbers[num + x];
                            numbers[num + x] = 0;
                            done[num + x] = 1;
                            done[num + 1] = 0;
                        }
                        else
                        {
                            ready2 = 1;
                        }
                    }
                    if (num - 1 >= 0 && ready2 != 1)
                    {
                        if (done[num - 1] == 1)
                        {
                            for (x = 1; x < numbers.Length; x++)
                            {
                                if (done[num - x] == 0)
                                {
                                    break;
                                }
                            }
                            numbers[num - 1] = numbers[num - x];
                            numbers[num - x] = 0;
                            done[num - x] = 1;
                            done[num - 1] = 0;
                        }
                    }
                    if (ready != 1)
                    {
                        total = numbers[num - 1] - numbers[num];
                        done[num - 1] = 1;
                        numbers[num - 1] = 0;
                        numbers[num] = total;
                    }
                    else if (ready == 1)
                    {
                        total = numbers[num] - numbers[num + 1];
                        done[num] = 1;
                        numbers[num] = 0;
                        numbers[num + 1] = total;
                    }
                    math[num] = null;
                }
                else
                {
                    check++;
                }
                ready = 0;
            }
            Results.Text += Input.Text + "=" + total;
            Input.Text = "";
            StartEntry = true;
            total = 0;
            count = 0;
            //making the numbers array back to zero
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }
            //making the math array back to null
            for (int i = 0; i < math.Length; i++)
            {
                math[i] = null;
            }
            //making the done array back to zero
            for(int i = 0; i < done.Length; i++)
            {
                done[i] = 0;
            }
        }
        private void ClearInput_Click(object sender, EventArgs e)
        {
            Input.Text = "";
        }
        private void ClearHistory_Click(object sender, EventArgs e)
        {
            Results.Text = "";
            count = 0;
            //making the numbers array back to zero
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }
            //making the math array back to null
            for (int i = 0; i < math.Length; i++)
            {
                math[i] = null;
            }
        }
    }
}
