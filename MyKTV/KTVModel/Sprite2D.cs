using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyKTV.KTVEnum;

namespace MyKTV.KTVModel
{
    public class Sprite2D
    {
        /// <summary>
        /// 精灵Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 2D精灵类型
        /// </summary>
        public Sprite2DType Type { get; set; }

        /// <summary>
        /// 文字内容
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 描边宽度
        /// </summary>
        public int TextBorder { get; set; }

        /// <summary>
        /// 字体
        /// </summary>
        public Font TextFont { get; set; } = new Font("Microsoft YaHei", 18, FontStyle.Regular);

        /// <summary>
        /// 颜色
        /// </summary>
        public Color TextColor { get; set; } = Color.White;
        /// <summary>
        /// 行宽
        /// </summary>
        public int LineWidth { get; set; } = 500;

        /// <summary>
        /// 行距
        /// </summary>
        public int LineHeight { get; set; } = 2;

        /// <summary>
        /// 图片精灵
        /// </summary>
        public Bitmap Image { get; set; }

        /// <summary>
        /// 精灵左边距离
        /// </summary>
        public int Left { get; set; } = 50;

        /// <summary>
        /// 精灵上方距离
        /// </summary>
        public int Top { get; set; } = 50;

        /// <summary>
        /// 是否单独存在的精灵
        /// </summary>
        public bool IsOnly { get; set; }

        /// <summary>
        /// 是否需要删除
        /// </summary>
        public bool IsNeedRemove { get; set; }


        public Sprite2D(bool needRemove,int second=3)
        {
            if (needRemove)
            {
                new Thread(() =>
                {
                    Thread.Sleep(second * 1000);
                    IsNeedRemove = true;
                }).Start();
            }
        }

        public override string ToString()
        {
            if (Type == Sprite2DType.text)
            {
                string temp = "text:";
                temp += Text + ";";
                temp += TextFont.Name + ";";
                temp += int.Parse(TextFont.Size.ToString()) + ";";
                temp += int.Parse((TextFont.Size * 2.5).ToString()) + ";";
                temp += TextFont.Bold ? "200;" : "0;";
                temp += TextFont.Italic ? "200;" : "0;";
                temp += TextFont.Underline ? "200;" : "0;";
                temp += ColorTranslator.ToWin32(TextColor) + ";";
                temp += TextBorder + ";";
                temp += LineWidth + ";";
                temp += LineHeight;
                return temp;
            }
            if (Type == Sprite2DType.image && Image != null)
            {
                string temp = "image:handle:";
                temp += Image.GetHbitmap(Color.Transparent) + ";";
                temp += ColorTranslator.ToWin32(TextColor);
                return temp;
            }
            return base.ToString();
        }
    }
}
