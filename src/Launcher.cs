using System;
using System.Diagnostics;

class Program {
    static void Main(string[] args) {
        // We expect an input like: "winsearchgoogle:https://google.com/..."
        if (args.Length > 0) {
            string rawUrl = args[0];
            
            // Safety check: ensure it starts with our prefix
            if (rawUrl.StartsWith("winsearchgoogle:")) {
                // Strip the "winsearchgoogle:" part (16 chars) to get the real URL
                string realUrl = rawUrl.Substring(16);
                
                // Launch the real URL in your default browser
                Process.Start(realUrl);
            }
        }
    }
}