using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Calc_Calories : Form
    {
        public Calc_Calories()
        {
            InitializeComponent();
        }

        private int FatCalories(int grams)
        {
            return grams * 9;
        }

        private int CarbCalories(int grams)
        {
            return grams * 4;
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool fatsComplete = true, carbsComplete = true;

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            FatsLBL.Text = "Grams of Fats?";
            FatsTB.Clear();
            FatsTB.Enabled = true;
            fatsComplete = true;


            CarbsLBL.Text = "Grams of Carbs?";
            CarbsTB.Clear();
            CarbsTB.Enabled = true;
            carbsComplete = true;
        }

        private void CalcBTN_Click(object sender, EventArgs e)
        {
            

            if (int.TryParse(FatsTB.Text, out int fatGrams) && fatsComplete)
            {
                FatsTB.Text = FatCalories(fatGrams).ToString();
                FatsTB.Enabled = false;
                FatsLBL.Text = "Calories from Fat";
                fatsComplete = false;
            }

            if (int.TryParse(CarbsTB.Text, out int carbGrams) && carbsComplete)
            {
                CarbsTB.Text = CarbCalories(carbGrams).ToString();
                CarbsTB.Enabled = false;
                CarbsLBL.Text = "Calories from Carbs";
                carbsComplete = false;
            }
        }


    }
}
