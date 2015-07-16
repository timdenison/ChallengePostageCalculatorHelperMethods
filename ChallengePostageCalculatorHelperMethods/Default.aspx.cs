using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;



namespace ChallengePostageCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
            //   main();
            //}
        }

       public void main(string textBoxID)
        {
           switch (textBoxID)
           {
               case "widthInput":
                   textBoxID = "heightInput";
                   break;
               case "heightInput":
                   textBoxID = "lengthInput";
                   break;
               case "lengthInput":
                   textBoxID = "widthInput";
                   break;
           }
           this.FindControl(textBoxID).Focus();

            if (buttonIsChecked())
            {
                
                if (validRequest())
                {
                    int w = (string.IsNullOrWhiteSpace(widthInput.Text)) ? 1 : Convert.ToInt32(widthInput.Text);
                    int h = (string.IsNullOrWhiteSpace(heightInput.Text)) ? 1 : Convert.ToInt32(heightInput.Text);
                    int l = (string.IsNullOrWhiteSpace(lengthInput.Text)) ? 1 : Convert.ToInt32(lengthInput.Text);
                    int volume = calcVolume(w, h, l);



                    if (shippingGroundRadioButton.Checked)
                    {
                        result.Text = String.Format("Your parcel will cost {0:C} to ship.", (volume * .15));
                    }
                    else if (shippingAirRadioButton.Checked)
                    {
                        result.Text = String.Format("Your parcel will cost {0:C} to ship.", (volume * .25));
                    }
                    else if (shippingNextDayRadioButton.Checked)
                    {
                        result.Text = String.Format("Your parcel will cost {0:C} to ship.", (volume * .45));
                    }


                }
                else
                {
                    MessageBox.Show("Please enter at least two measurements.", "Try again, Chump.", MessageBoxButtons.OK);
                }
            }

            }
       public void main()
       {
           
           if (buttonIsChecked())
           {

               if (validRequest())
               {
                   int w = (string.IsNullOrWhiteSpace(widthInput.Text)) ? 1 : Convert.ToInt32(widthInput.Text);
                   int h = (string.IsNullOrWhiteSpace(heightInput.Text)) ? 1 : Convert.ToInt32(heightInput.Text);
                   int l = (string.IsNullOrWhiteSpace(lengthInput.Text)) ? 1 : Convert.ToInt32(lengthInput.Text);
                   int volume = calcVolume(w, h, l);



                   if (shippingGroundRadioButton.Checked)
                   {
                       result.Text = String.Format("Your parcel will cost {0:C} to ship.", (volume * .15));
                   }
                   else if (shippingAirRadioButton.Checked)
                   {
                       result.Text = String.Format("Your parcel will cost {0:C} to ship.", (volume * .25));
                   }
                   else if (shippingNextDayRadioButton.Checked)
                   {
                       result.Text = String.Format("Your parcel will cost {0:C} to ship.", (volume * .45));
                   }


               }
               else
               {
                   MessageBox.Show("Please enter at least two measurements.", "Try again, Chump.", MessageBoxButtons.OK);
               }
           }

       }

       public int calcVolume(int width, int height, int length)
        {
            int volume = width * height * length;
            return (volume);
        }

       public bool validRequest()
       {
           if (buttonIsChecked())
           {
               int fieldCount = 0;
               fieldCount = (string.IsNullOrWhiteSpace(widthInput.Text)) ? fieldCount : fieldCount + 1;
               fieldCount = (string.IsNullOrWhiteSpace(heightInput.Text)) ? fieldCount : fieldCount + 1;
               fieldCount = (string.IsNullOrWhiteSpace(lengthInput.Text)) ? fieldCount : fieldCount + 1;

               if (fieldCount >= 2)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           else
           {
               return false;
           }
       }

       protected void text_TextChanged(object sender, EventArgs e)
       {
           
           System.Web.UI.WebControls.TextBox currentTextBox = (System.Web.UI.WebControls.TextBox)sender;
           string idString = currentTextBox.ID;
           //var nextElement = currentElement.NextSibling;
           main(idString);
       }

     
       protected void radioButton_CheckedChanged(object sender, EventArgs e)
       {
           main();
       }
        
        protected bool buttonIsChecked()
       {
            if (shippingGroundRadioButton.Checked || shippingAirRadioButton.Checked || shippingNextDayRadioButton.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
       }
    }
}