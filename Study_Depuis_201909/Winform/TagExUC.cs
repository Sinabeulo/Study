using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class TagExUC : UserControl
    {
        public TagExUC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 동적 버튼 컨트롤 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_create_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                var bt = new Button() { Tag = "Tag " + i, Text = i.ToString() };
                bt.Location = new Point(i * 100 + 10, 80);
                bt.Click += Bt_Click;

                // 폼에 표시하기
                this.Controls.Add(bt);
            }
        }

        // 버튼 클릭 이벤트
        private void Bt_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;

            lb_Tag.Text = button.Tag.ToString();
        }
    }
}
