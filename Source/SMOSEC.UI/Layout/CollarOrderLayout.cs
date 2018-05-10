using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.UI.AssetsManager;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class CollarOrderLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private void Panel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmCoDetail coDetail=new frmCoDetail();
                coDetail.CoId = LblID.BindDataValue.ToString();
                Form.Show(coDetail);
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }
    }
}