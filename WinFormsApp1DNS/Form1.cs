using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Net;
namespace WinFormsApp1DNS;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonGetHost_Click(object sender, EventArgs e)
    {
        string ipText = textBoxIpAddress.Text.Trim();

        try
        {
            IPAddress ip = IPAddress.Parse(ipText);
            IPHostEntry entry = Dns.GetHostEntry(ip);
            labelHostName.Text = entry.HostName;

            Debug.WriteLine($"Host name: {entry.HostName}");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void buttonGetIp_Click(object sender, EventArgs e)
    {
        listBoxAddresses.Items.Clear();
        string url = textBoxHostName.Text;
        url = url.Trim();
        string host = ExtractHost(url);
        try
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(host);
            IPAddress[] addresses = hostEntry.AddressList;
            if (addresses.Length > 0)
            {
                foreach (var item in addresses)
                {
                    listBoxAddresses.Items.Add(item.ToString());
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
    private void buttonPing_Click(object sender, EventArgs e)
    {
        CheckRoutes();
    }

    private string ExtractHost(string url)
    {
        if (!string.IsNullOrEmpty(url))
        {
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "https://" + url;
            }
            Uri uri = new Uri(url);
            return uri.Host;
        }
        return string.Empty;
    }
    // ox.ac.uk (Оксфордський університет, Велика Британія)
    // uic.es (Університет Каталонії, Іспанія)
    // CERN.ch (Європейська організація з ядерних досліджень, Швейцарія)
    // mit.edu (Массачусетський технологічний інститут)
    // stanford.edu (Стенфордський університет)
    // nasa.gov (NASA, США)
    // u-tokyo.ac.jp (Токійський університет, Японія)
    // nus.edu.sg (Національний університет Сінгапуру)
    // unimelb.edu.au (Мельбурнський університет, Австралія)
    // nyu.edu (Нью-Йоркський університет)
    private int maxHops = 30;
    private int timeout = 1000;
    private void CheckRoutes()
    {
        CheckRoute("nyu.edu");
    }

    private void CheckRoute(string host)
    {
        //StringBuilder stringBuilder = new StringBuilder();

        using Ping pingSender = new Ping();

        //byte[] buffer = Encoding.UTF8.GetBytes("data");
        byte[] buffer = Encoding.ASCII.GetBytes("data");

        for (int ttl = 1; ttl <= maxHops; ttl++)
        {
            // Set the Time-to-Live (TTL) for this specific iteration// The 'true' flag prevents the packet from being fragmented
            PingOptions options = new PingOptions(ttl, true);
            // Send the ICMP Echo request
            PingReply reply = pingSender.Send(host, timeout, buffer, options);

            if (reply.Status == IPStatus.TtlExpired)
            {
                // The packet "died" at an intermediate router, providing us its IP
                Debug.WriteLine($"{ttl,2} | IP: {reply.Address,-15} | Time: {reply.RoundtripTime}ms");
            }
            else if (reply.Status == IPStatus.Success)
            {
                // The packet successfully reached the final destination
                Debug.WriteLine($"{ttl,2} | IP: {reply.Address,-15} | Reached! Final ping: {reply.RoundtripTime}ms");
                break;
            }
            else if (reply.Status == IPStatus.TimedOut)
            {
                // The router or destination host did not respond within the timeout period
                Debug.WriteLine($"{ttl,2} | IP: * * * | Request timed out");
            }
            else
            {
                // Handle other possible network errors (e.g., Destination Unreachable)
                Debug.WriteLine($"{ttl,2} | Error: {reply.Status}");
            }
        }

        Debug.WriteLine("\nTrace complete.");
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        //Thread thread = new Thread(WriteFile);
        //thread.Start("text");

        //await WriteFileAsync("text");

        //WriteFile("text");//UI Thread blocked

        int result = await MakeMathOperation();
        Debug.WriteLine(result);
    }
    //write txt file sync
    private void WriteFile(string text)
    {
        string textToWrite = "Text:" + text;
        Thread.Sleep(5000);
        File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "file_async.txt"), textToWrite);
        Debug.WriteLine("Completed");
    }
    //write txt file async
    private async Task WriteFileAsync(string text)
    {
        string textToWrite = "Text:" + text;
        //Thread.Sleep(3000);
        await Task.Delay(5000);
        await File.WriteAllTextAsync(Path.Combine(Directory.GetCurrentDirectory(), "file_async.txt"), textToWrite);
        Debug.WriteLine("Completed");

    }
    private async Task<int> MakeMathOperation()
    {
        // duration 30s.
        return await Task.Run(() => { return Calculate(); });

    }

    private int Calculate()
    {
        Thread.Sleep(10000);

        return 10;
    }

    private async void buttonGet_Click(object sender, EventArgs e)
    {
        //https://api.github.com/zen
        string url = "https://api.github.com/zen";
        url = url + "?time=100" + DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        using HttpClient httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/140.0.0.0 Safari/537.36");
        httpClient.DefaultRequestHeaders.Add("Pragma", "no-cashe");
        try
        {
            string data = await httpClient.GetStringAsync(url);
            textBoxOutput.Text = data;
        }
        catch (HttpRequestException re)
        {
            Debug.WriteLine("HttpRequestException:" + re.Message);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Exception:" + ex.Message);
        }

    }

    private async void buttonPing3_Click(object sender, EventArgs e)
    {
        textBoxPing.Clear();
        string ip=textBoxIpAddress.Text.Trim();
        if(!string.IsNullOrEmpty(ip))
        {
            try
            {
                using Ping ping= new Ping();
                for (int i=1;i<=3;i++)
                {
                    PingReply reply = await ping.SendPingAsync(ip,2000);
                    if (reply.Status == IPStatus.Success)
                    {
                        textBoxPing.AppendText($"{i}. Ping to {ip}:Succes.Time:{reply.RoundtripTime}ms."+Environment.NewLine);
                    }
                    else
                    {
                        textBoxPing.AppendText($"{i}. Ping to {ip}:{reply.Status}" + Environment.NewLine);
                    }

                }
            }
            catch(Exception ex)
            {
                textBoxPing.AppendText($" Ping to {ip} error :{ex.Message}" + Environment.NewLine);
            }
            await Task.Delay(1000);
        }
    }
}
