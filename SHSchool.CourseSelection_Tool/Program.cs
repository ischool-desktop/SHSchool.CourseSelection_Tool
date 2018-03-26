using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FISCA;
using FISCA.Presentation;

namespace SHSchool.CourseSelection_Tool
{
    public class Program
    {
        [MainMethod("選課模組2.0")]

        static public void Main()
        {
            #region 開發工具-自動填入學生選課志願
            RibbonBarButton mb = MotherForm.RibbonBarItems["教務作業", "開發工具"]["產生學生選課志願"];
            mb.Size = RibbonBarButton.MenuButtonSize.Medium;
            mb.Image = Properties.Resources.Import_Image;

            mb.Click += delegate
            {
                AutoSelectStuWish at = new AutoSelectStuWish();
                at.ShowDialog();
            };

            #endregion
        }
    }
}
