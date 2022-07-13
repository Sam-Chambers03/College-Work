using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuoteCalculatorAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BCalculate_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbAdditionalWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void BCalculate_Click_1(object sender, EventArgs e)
        {
            #region Check Name and Date are filled out
            /*
             * this section of code checks that there is an entry for the
             * name and date, this allows for the name and date entered to be 
             * saved on the final quote
             */

            if (string.IsNullOrWhiteSpace(tbName.Text)) //checking if string is empty or no input
            {
                MessageBox.Show("Invalid input: Please type a Name to Save the Quote."); //error message for the above statement
            }
            else if (string.IsNullOrWhiteSpace(mtbDate.Text))
            {
                MessageBox.Show("Invalid input: Please type a Date to save on the Quote.");
            }

            #endregion

            #region Weight of product.

            //this try method essentially tests the code bellow and if there is an error 
            //it will do the code in the catch block if not it will continue as normal

            // these set of if statments checks the product weight and 
            // checks which bound it falls into and applys the 
            // appropriate multiplyer to the base price.

            double basePrice = 0;
            double productWeight;

            if (string.IsNullOrWhiteSpace(tbWeight.Text))
            {
                MessageBox.Show("Invalid input: Please Enter a Weight.");
            }
            else
            {
                //if (!double.TryParse(tbWeight.Text, out productWeight))
                //{
                //    MessageBox.Show("Invalid input: Please try again.");
                //}

                double weightMultiplyer = 0; // variables for the bellow calculations
                double additionalWeightPrice = 0;

                productWeight = Convert.ToInt32(tbWeight.Text);  //Converts the string in the text box to a integer


                if (productWeight < 50)  // statement deciding if the weight is bellow 50grams  
                {
                    basePrice = (basePrice + 0.20); // multipler o.2 is for weight bellow 50grams 
                }

                else if (productWeight >= 50 && productWeight < 100)
                {
                    basePrice = (basePrice + 0.45);     // multipler o.45 is for weight between 50 and 100grams  
                }

                else if (productWeight >= 100 && productWeight <= 200)
                {
                    basePrice = (basePrice + 0.60);     // multipler o.60 is for weight between 100 and 1200grams  
                }

                else if (productWeight > 200)   // this satement decides if the weight is more than 200grams
                {
                    weightMultiplyer = productWeight / 100;             // this finds out how  many groups off 100 go into the weight
                    weightMultiplyer = weightMultiplyer - 2;            // becasue the multipler is more than 200gram then each addtional 100g is 0.2 2 groups of 100 have to be taken away
                    basePrice = basePrice + 0.60;                       // the price for the first 200g are added
                    additionalWeightPrice = weightMultiplyer * 0.2;     // this then adds the price for the additional weight
                    basePrice = basePrice + additionalWeightPrice;
                }
            }

            #endregion

            #region Moulding Technique

            /*
             * this uses a switch method this is like an if statement but more effective
             * they cases and theses are the posible outcomes that can happen
             * this then multiplys the base price by the appropriate multiplyer
             * from the appropriate case.
             */
            if (cbMouldingTechnique.SelectedIndex < 0)  // makes sure there is a selection in the combo box
            {
                MessageBox.Show("Invalid input: Please Select a Moulding Technique.");
            }
            else
            {
                switch (cbMouldingTechnique.SelectedIndex) // checks the selcetion
                {
                    case 0: // selections are done in binary so 0 is the first option
                        basePrice = (basePrice * 1.10);
                        break;
                    case 1:
                        basePrice = (basePrice * 1.05);
                        break;
                    case 2:
                        basePrice = (basePrice * 1.00);
                        break;
                    case 3:
                        basePrice = (basePrice * 1.20);
                        break;
                }
            
            }

            #endregion

            #region Material Used

            if (cbMaterialType.SelectedIndex < 0) // checks the combo box has a selection
            {
                MessageBox.Show("Invalid input: Please Select a Material Type."); // error is no selection made
            }
            else
            {
                switch (cbMaterialType.SelectedIndex)  //checks the selection 
                {
                    case 0: // selections are done in binary so 0 is the first option
                        basePrice = (basePrice * 1.10);  // this adds the price for vaccum moulding
                        break;

                    case 1:
                        basePrice = (basePrice * 1.05); 
                        break;

                    case 2:
                        basePrice = (basePrice * 1.10);    // adds the price for injection moulding
                        break;

                    case 3:
                        basePrice = (basePrice * 1.20);
                        break;

                    case 4:
                        basePrice = (basePrice * 1.30);
                        break;

                    case 5:
                        basePrice = (basePrice * 1.0);
                        break;
                }
            }

            #endregion

            #region Product Colour
            if (rbBespokeRange.Checked || rbStandardRange.Checked) //checks either of the colour ranges are checked
            {
                if (rbStandardRange.Checked) // standard colour range
                {
                    basePrice = basePrice * 1.0; // adds price for standard color range
                }
                else if (rbBespokeRange.Checked)    // bespoke colour range
                {
                    basePrice = basePrice * 1.10;   // adds price for the bespoke colour range
                }
            }
            else
            {
                MessageBox.Show("Invalid input: Please Select a Colour range.");    // error for when a colour range is not selected
            }


            #endregion

            #region Number of components

            if (string.IsNullOrWhiteSpace(tbNumComponents.Text))    // checks is the text box for numComponents is empty or written in
            {
                MessageBox.Show("Invalid input: Please enter the number of components used.");  //error is no string is entered
            }
            else
            {
                int individualComponents = Convert.ToInt32(tbNumComponents.Text);  // Converts the string in the text box 
                                                                                   // of numbers of components to a integer
                basePrice = basePrice * individualComponents;
            }

            #endregion

            #region Finishing method

            if(cbFettling.Checked || cbHandPainting.Checked || cbTransfersUsed.Checked || cbPartsAssembly.Checked)  // checks is any of the finishing methods are checked
            {
                if (cbFettling.Checked) // if fettling is checked then it will times by 1.5
                {
                    basePrice = basePrice * 1.5;
                }
                else if (cbHandPainting.Checked)    // if hand painting is checked then it will times by 1.4
                {
                    if (string.IsNullOrWhiteSpace(tbNumColoursUsed.Text))   // if handpainting is checked there must be a number of colours used
                    {
                        MessageBox.Show("Invalid input: Please enter the number of colours used.");
                    }
                    else if (cbHandPainting.Checked)       // completes the calculations if handpainting is checked
                    {
                        int numColoursUsed = Convert.ToInt32(tbNumColoursUsed.Text);

                        if (numColoursUsed > 1)
                        {
                            double colourMultiplyer = numColoursUsed * 1.4;
                            basePrice = basePrice + colourMultiplyer;
                        }
                        else
                        {
                            basePrice = basePrice * 1.4;
                        }
                    }
                }
                else if (cbTransfersUsed.Checked)       // completes calculations if transfers is checked
                {
                    if (string.IsNullOrWhiteSpace(tbNumTransfers.Text))
                    {
                        MessageBox.Show("Invalid input: Please enter the number of transfers used.");
                    }
                    int numTransfers;
                    double transferPrice;

                    numTransfers = Convert.ToInt32(tbNumTransfers.Text);    // checks how many transfers are used
                    if (numTransfers > 1)   // checks the num of transfers if grater than 1 then will times num of transfers by 1.2 and add to price
                    {
                        transferPrice = numTransfers * 1.2;
                        basePrice = basePrice + transferPrice;
                    }
                    else if (numTransfers == 1) // adds the standard price for one transfers
                    {
                        basePrice = basePrice * 1.2;
                    }
                }
                else if (cbPartsAssembly.Checked) // completes the calculations for parts assembly
                {
                    if (string.IsNullOrWhiteSpace(tbNumParts.Text))
                    {
                        MessageBox.Show("Invalid input: Please enter the number of parts used.");
                    }
                    int numPartsAssembly;
                    double assemblyPrice;

                    numPartsAssembly = Convert.ToInt32(tbNumParts.Text);

                    if (numPartsAssembly <= 2)
                    {
                        basePrice = basePrice * 1.1;
                    }
                    else if (numPartsAssembly > 2)
                    {
                        basePrice = basePrice * 1.1;

                        numPartsAssembly = numPartsAssembly - 2;
                        assemblyPrice = numPartsAssembly * 1.05;
                        basePrice = basePrice * assemblyPrice;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input: Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input: Please Select a Finishing Method.");
            }

            #endregion

            #region Quantity of product

            if (string.IsNullOrWhiteSpace(tbQuantity.Text))     //checks if the quantity text box has an input
            {
                MessageBox.Show("Invalid input: Please Input a Quantity.");
            }
            else
            {
                double quantity = Convert.ToInt32(tbQuantity.Text);  //Converts the string in the text box to a integer

                basePrice = basePrice * quantity;
                /*
                 * this set of if statements check which bound the quantity the customer wants and adds the 
                 * appropriate price acording to the multiplyer.
                 */

                if (quantity > 1 && quantity < 49)
                {
                    basePrice = basePrice * 1.8;    // multiplys price for 1 - 49 weight catogory 

                }
                else if (quantity > 50 && quantity < 99)
                {
                    basePrice = basePrice * 1.2;

                }
                else if (quantity > 100 && quantity < 499)
                {
                    basePrice = basePrice * 1.0;

                }
                else if (quantity > 500 && quantity < 999)
                {
                    basePrice = basePrice * 0.7;

                }
                else if (quantity > 1000)
                {
                    basePrice = basePrice * 0.6;

                }
                else
                {
                    MessageBox.Show("Invalid input: Please try again.");
                }
            }

            #endregion

            #region Design and Mould creation
            /*
             * this uses a switch method this is like an if statement but more effective
             * they use cases and theses are the posible outcomes that can happen from the combobox
             * this then multiplys the base price by the appropriate multiplyer
             * from the appropriate case.
             * 
             * in this instance case 0 is new mould required so £1000 is added to base price
             * and case 0 is there is already a mould created.
             */
            if(cbMoulds.SelectedIndex < 0)      // checks there is an input for the mould selection
            {
                MessageBox.Show("Invalid input: Please select a mould option.");
            }
            else
            {
                switch (cbMoulds.SelectedIndex)
                {
                    case 0:
                        basePrice = basePrice + 1000; // adds 1000 to the price if a new mould is needed
                        break;

                    case 1:
                        basePrice = basePrice + 0;      // no price is mould avalible
                        break;
                }
            }

            #endregion

            #region Final Price to text box

            string finalPrice;      // creates the variables for the final price 
            double basePriceRound = basePrice;

            Math.Round(basePriceRound, 2); // this rounds the base price to 2 decimal places

            finalPrice = Convert.ToString(basePriceRound);        // This outputs the final price to a textbox
            tbfinalPrice.Text = finalPrice; // makes the text box on the main program show the final price

            #endregion
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void TbAdditionalParts_TextChanged(object sender, EventArgs e)
        {

        }
        private void TbNumComponents_TextChanged(object sender, EventArgs e)
        {

        }
        #region Save to txt

        private void Button1_Click(object sender, EventArgs e)
        {
            /*
             * this section of code takes the users name and the final price 
             * and saves it to a text file.
             */

            if (string.IsNullOrEmpty(tbFilePath.Text))  //checks there is a file path
            {
                MessageBox.Show("Invalid input: Please enter a file path to save the quote to."); //error message for the above statement
            }
            else
            {
                string filePath = @"" + tbFilePath.Text + "/" + tbName.Text + " " + mtbDate.Text + " Quote.txt";  // file path
                string clientName = Convert.ToString(tbName.Text);  // variables for the text file
                string quoteDate = Convert.ToString(mtbDate.Text);

                StreamWriter quote = new StreamWriter(filePath);        // creates the stream writer

                //using (StreamWriter quote = File.CreateText(@"D:\Unit4AssignmentQuotes"))

                quote.WriteLine($"{quoteDate} \nThe final price for {clientName} with the options that were selected is: £{tbfinalPrice.Text}");        // the contents of the text file

                quote.Close();  // closes text file

                MessageBox.Show($"The Quote for {clientName} has been saved."); // message box to show text file is saved
            }
        }
        #endregion

        #region Validate text boxes for only integers
        private void TbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * this section of code prevents any key other 
             * than Delete, backspace and fullstop or numbers from being
             * entered into the text box
             */

            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void TbNumComponents_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * this section of code prevents any key other 
             * than Delete, backspace and fullstop or numbers from being
             * entered into the text box
             */

            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)   
            {
                e.Handled = true;
            }
        }

        private void TbNumColoursUsed_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * this section of code prevents any key other 
             * than Delete, backspace and fullstop or numbers from being
             * entered into the text box
             */

            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)    
            {
                e.Handled = true;
            }
        }
        
        private void TbAdditionalParts_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * this section of code prevents any key other 
             * than Delete, backspace and fullstop or numbers from being
             * entered into the text box
             */

            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)   
            {
                e.Handled = true;
            }
        }

        private void BPrintTxt_Click(object sender, EventArgs e)
        {

        }

        private void TbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * this section of code prevents any key other 
             * than Delete, backspace and fullstop  or numbers from being
             * entered into the text box
             */

            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)    
            {
                e.Handled = true;
            }
            
        }


        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * this section of code prevents any key, other 
             * than Delete, backspace, spacebar and fullstop  or letters from being
             * entered into the text box
             */

            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)   
            {
                e.Handled = true;
            }
        }

        private void TbNumParts_KeyUp(object sender, KeyEventArgs e)
        {

        }


        private void TbNumParts_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            * this section of code prevents any key other 
            * than Delete, backspace and fullstop or numbers from being
            * entered into the text box
            */

            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        private void tbFilePath_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
