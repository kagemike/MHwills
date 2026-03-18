using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chose
{
    public partial class Form1 : Form
    {
        // 1. 宣告一個陣列來存放你準備好的圖片資源
        // 注意：這裡的 pic1, pic2, pic3 必須與你在「資源」中加入的圖片名稱一致
        private Image[] prizeImages;

        // 2. 宣告隨機數產生器
        private readonly Random randomGenerator;

        public Form1(Random randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }

        public Form1()
        {
            InitializeComponent();
            // 在程式啟動時初始化圖片清單與亂數產生器
            prizeImages = new Image[]
            {
                Properties.Resources.Bow,
                Properties.Resources.Dual_Blades,
                Properties.Resources.Great_Sword,
                Properties.Resources.Gunlance,
                Properties.Resources.hammer,
                Properties.Resources.Heavy_Bowgun,
                Properties.Resources.Hunting_Horn,
                Properties.Resources.Insect_Glaive_1,
                Properties.Resources.Lance,
                Properties.Resources.Switch_Axe,
                Properties.Resources.Sword___Shield,
                Properties.Resources.Long_Sword,
                Properties.Resources.Light_Bowgun,
                Properties.Resources.Charge_Blade
            };

            randomGenerator = new Random();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 3. 產生一個介於 0 到 (圖片數量 - 1) 之間的隨機整數
            int randomIndex = randomGenerator.Next(0, prizeImages.Length);

            // 4. 將隨機選中的圖片，輸出 (賦值) 給 PictureBox 來顯示
            pictureBox2.Image = prizeImages[randomIndex];

        }
    }
}
