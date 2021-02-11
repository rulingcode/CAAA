using layer_1;
using layer_2;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace z_service_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string skeletid = "k_windows";
        static o2 o2;
        static IMongoDatabase db;
        static IMongoCollection<item> coll_save;
        class item
        {
            public string id { get; set; }
            public byte[] data { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            o2 = o2.create();
            o2.skeletid = skeletid;
            o2.get_password = get_password;
            o2.check_password = check_password;
            o2.key_c = public_key.data;
            o2.key_s = private_key.data;
            o2.load = load;
            o2.logout_s = logout;
            o2.report_h = report;
            o2.save = save;
            o2.x_m = new m_x() { data = res.get_endpoint(10000).ToString(), id = "x_center" };
            MongoClient mc = new MongoClient();
            db = mc.GetDatabase("x_center");
            coll_save = db.GetCollection<item>("coll_save");
            o2.start();
            o2.add_x(o2.x_m);
            o2.add_y<y_test_imp>();
           // run();
        }

        static async void run()
        {
            y_test y = new y_test()
            {
                a = 5,
                b = 4
            };
            var dv = await y.run_c(o2.run("ali"));
        }

        async Task<string> get_password(string userid)
        {
            switch (userid)
            {
                case skeletid: return "fkvjfjbhghchdhv";
                case "ali": return "kfkvjfjvjd";
            }
            return await Task.FromResult(null as string);
        }
        private void save(string key, byte[] data)
        {
            coll_save.ReplaceOne(i => i.id == key, new item() { id = key, data = data });
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        private Task<bool> logout(string deviceid, string userid)
        {
            throw new NotImplementedException();
        }
        async Task<byte[]> load(string key)
        {
            await Task.CompletedTask;
            return coll_save.Find(i => i.id == key).FirstOrDefault()?.data;
        }
        async Task<bool> check_password(m_login rsv)
        {
            switch (rsv.userid)
            {
                case skeletid: return rsv.password == "fkvjfjbhghchdhv";
                case "ali": return rsv.password == "kfkvjfjvjd";
            }
            return await Task.FromResult(false);
        }
    }
}
