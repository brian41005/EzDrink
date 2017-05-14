using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    //操作一些message box 或 file dialog
    public class EzDrinkFormToolBox
    {
        private const string ABOUT = "Author: 馬茂源\n學號: 103590450\nVersion: 4.1\n最後更新日期: 2016/11/12";
        private const string ABOUT_TITLE = "About";
        private const string DELETE_QUESTION_CAPTION = "Important Question";
        private const string LOAD_FILE_QUESTION = "檔案重新載入後，已存在點單內的內容將無法同步，仍要載入?";
        private const string WARNING_CAPTION = "Warning";
        private const string DELETE_QUESTION = "是否刪除?";
        private const string NEW_ERROR = "資料重複或新增錯誤";
        private const string TEXT_FILTER = "txt files (*.txt)|*.txt";
        private const string LOAD_FILE_TITLE = "Select a Text File";
        private const string LOADING_ERROR = "讀取檔案格式或內容錯誤";

        //Get File Name
        public string GetFileName()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = TEXT_FILTER;
            openFileDialog.Title = LOAD_FILE_TITLE;
            DirectoryInfo directory = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            openFileDialog.InitialDirectory = directory.Parent.Parent.FullName;
            openFileDialog.RestoreDirectory = true;
            DialogResult result = openFileDialog.ShowDialog();
            return openFileDialog.FileName;

        }

        //Is Loading Warning
        public bool IsLoadingWarning(string fileName)
        {
            //if (fileName == string.Empty)
            //    return false;
            return DialogResult.Yes == MessageBox.Show(LOAD_FILE_QUESTION, WARNING_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        //Delete Dialog
        public DialogResult GetDeleteDialog()
        {
            return MessageBox.Show(DELETE_QUESTION, DELETE_QUESTION_CAPTION, MessageBoxButtons.YesNo);
        }

        //Get New Item Error
        public void GetNewItemError()
        {
            MessageBox.Show(NEW_ERROR, WARNING_CAPTION);
        }

        //Load Error
        public void LoadError()
        {
            MessageBox.Show(LOADING_ERROR, WARNING_CAPTION);
        }

        //Show About
        public void ShowAbout()
        {
            MessageBox.Show(ABOUT, ABOUT_TITLE);
        }

    }
}
