/*
 * 姓名:          馬茂源
 * 學號:          103590450
 * 班級:          四資三
 * Description:   Windows Programming HW3, back stage subsystem.
 */
using System;
using System.Windows.Forms;

namespace EzDrink
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DrinkModel ezDrinkModel = new DrinkModel();
            PresentationModel ezDrinkPresentationModel = new PresentationModel(ref ezDrinkModel);
            Application.Run(new EzDrinkForm(ref ezDrinkModel, ref ezDrinkPresentationModel));
        }
    }
}
