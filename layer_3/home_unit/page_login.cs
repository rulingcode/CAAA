﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace layer_3.home_unit
{
    class page_login : g_page
    {

        login_core core = new login_core() { MaxWidth = 400 };
        public page_login()
        {
            core.txt_phone.PreviewKeyDown += Txt_phone_PreviewKeyDown;
        }
        private void Txt_phone_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                var dv = message(z_message.e_type.error, "راهنمای اصلی", "تغییر کاربر", "بستن برنامه", "قفل صفحه", "mohsen", "ahmad");
            }
        }

        public override string page_name => "ورود یا ثبت نام";
        public override UIElement ui => core;
        protected override void focus()
        {
            core.txt_phone.Focus();
        }
    }
}
