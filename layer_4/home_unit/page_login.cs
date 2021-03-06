using skeleton.more_controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace skeleton.home_unit
{
    class page_login : g_page
    {

        StackPanel panel = new StackPanel()
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Width = 400
        };
        text_box txt_phone = new text_box();
        label_box panel_phone = new label_box() { title = "شماره تلفن همراه", title_direction = FlowDirection.RightToLeft };
        PasswordBox txt_password = new PasswordBox();
        label_box panel_pass = new label_box() { title = "رمز پیامک شده", title_direction = FlowDirection.RightToLeft };
        public page_login()
        {
            panel_phone.child = txt_phone;
            panel_pass.child = txt_password;
            panel.Children.Add(panel_phone);
            panel.Children.Add(panel_pass);
            txt_phone.PreviewKeyDown += Txt_phone_PreviewKeyDownAsync;
            reset();
        }
        enum e_state
        {
            set_phone,
            set_pass
        }
        e_state state = e_state.set_phone;
        private void reset()
        {
            switch (state)
            {
                case e_state.set_phone:
                    {
                        panel_pass.Visibility = Visibility.Collapsed;
                    }
                    break;
                case e_state.set_pass:
                    {

                    }
                    break;
            }
        }
        private async void Txt_phone_PreviewKeyDownAsync(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if(IsPhoneNumber(txt_phone.Text))
                {
                    
                }
                else
                {
                    await message(z_message.e_type.error, "شماره تلفن وارد شده صحیح نیست.");
                }
            }
        }
        static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(?:(\u0660\u0669[\u0660-\u0669][\u0660-\u0669]{8})|(\u06F0\u06F9[\u06F0-\u06F9][\u06F0-\u06F9]{8})|(09[0-9][0-9]{8}))$").Success;
        }
        public override string page_name => "ورود یا ثبت نام";
        public override UIElement ui => panel;
        protected override void focus()
        {
            txt_phone.Focus();
        }
    }
}
