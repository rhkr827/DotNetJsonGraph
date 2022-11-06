using System;
using System.IO;
using System.Windows;
using DotNetJsonGraph.Core;
using System.Text.Json;
using DotNetJsonGraph.Model;
using System.Collections.Generic;

namespace DotNetJsonGraph
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private async void Initialize()
        {   
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if(!Directory.Exists($"{appDirectory}/data")){
                Directory.CreateDirectory($"{appDirectory}/data");
            }

            var generate = new Generate();
            List<Item> items = generate.GetItems;
            List<Node> nodes = generate.GetNodes;

            using FileStream itemsStream = File.Create($"{appDirectory}/data/items.json");
            await JsonSerializer.SerializeAsync(itemsStream, items, new JsonSerializerOptions { WriteIndented=true});
            await itemsStream.DisposeAsync();

            using FileStream nodeStream = File.Create($"{appDirectory}/data/nodes.json");
            await JsonSerializer.SerializeAsync(nodeStream, nodes, new JsonSerializerOptions { WriteIndented=true});
            await nodeStream.DisposeAsync();

        }
    }
}
