# Fake Bank
A fake online banking site for keeping phone scammers busy, like the one seen in KitBoga's streams. It has a login with a captcha, an account page with balances and an inbox, and transfers between accounts. None of it is real: there is no database and no real money.

I was interested in learning how to make websites with C# so I chose to learn Blazor while making this.
Because I made this while learning, some of the stuff could probably be more efficient.

Styling based off https://github.com/jakejarvis/kitboga-bank

# Status
Learning project from February 2021. It ran when I last worked on it, and I no longer develop it. It targets .NET 5, which Microsoft no longer supports, so you need the .NET 5 SDK or you have to change `TargetFramework` in `Bank.csproj` yourself.

The `net8` branch is a rewrite I started in November 2024 (Blazor WebAssembly, Tailwind and a web API). It is unfinished.

# Starting
1. Download the .NET 5 SDK from [here](https://dotnet.microsoft.com/download/dotnet/5.0)
2. Clone this repository
3. Enter the folder of the repository and type `dotnet run`, then open http://localhost. (If you know what you're doing and want to make changes live, type `dotnet watch run`)
4. Configuration (bank name, accounts, theme) can be found in `Data/BrainService/Configuration.cs`.

# Setting Up a Fake Domain
1. Open Notepad (or any other text editor) as administrator.
2. Open file `C:\Windows\System32\drivers\etc\hosts`
    - You may need to set the file extension to .* (All Files)
3. On a new line add `127.0.0.1 yourwebsite.com`
    - Some TLDs such as `.bank` require a secure connection, for this you need to setup an ssl.
    - You will also need to change `profiles.Bank.applicationUrl` from `"http://localhost:80"` to `"https://localhost:443"`
4. Save the file
