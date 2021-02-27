# Fake Bank
I wanted to make a fake bank like the one seen in KitBoga's streams.
I was interested in learning how to make websites with C# so I chose to learn Blazor while making this.
Because I made this while learning, some of the stuff could probably be more efficient.

Styling based off https://github.com/jakejarvis/kitboga-bank

# Starting
1. Download the .NET SDK from (here)[https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.103-windows-x64-installer]
2. Clone this repository (`git clone https://github.com/Sampleeeee/fake-bank`)
3. Enter the folder of the repository and type `dotnet run`. (If you know what you're doing and want to make changes live, type `dotnet watch run`)
4. Configuration can be found in Data/BrainService.cs.

# Setting Up a Fake Domain
1. Open Notepad (or any other text editor) as administrator.
2. Open file C:\Windows\System32\drivers\etc\hosts
    - You may need to set the file extension to .* (All Files)
3. On a new line add `127.0.0.1 yourwebsite.com`
    - Some TLDs such as `.bank` require a secure connection, for this you need to setup an ssl.
4. Save the file

# Configuration
Better configuration coming soon

# Themes
Themes coming soon