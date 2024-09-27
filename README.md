# CNV-spec

An unofficial specification (find a official one, I dare you) of the so-called Cnv language.

The language has been used in the PIKLib (later: BlooMoo) engine in the Polish series of point-and-clicked games named "Przygody Reksia".
The series (as well as the engine) was made by Aidem Media (currently: [BoomBit](https://boombit.com)). Due to character license expiring, the games are no longer distributed (since January 2016).

## Why C#?

1. Describing an interface using a well-known language means there exists a convenient tool like [docfx](https://dotnet.github.io/docfx/) or even [doxygen](https://www.doxygen.nl/) to do the job smoothly in a standarized way.
2. C# is kinda similar to Cnv thanks to it being an object-oriented language and having its class members divided into fields/properties, methods and events.
   However there's a downside to be resolved yet: Cnv allows for a method and a property to share a name while C# doesn't.

## How it is done

1. All scripts from the series have been decoded and organized into a repository (a private one because making it public would of course be a copyright infringement).
2. The scripts have been [grepped](https://man7.org/linux/man-pages/man1/grep.1.html) heavily to extract all useful information like types, properties, methods and signals (events) available.
3. The resulting list of symbols have been organized into C# code with no documentation.
4. The documentation is slowly being re-created by checking the usage context of found symbols and observing the behavior of the original games after modifying their scripts.

The project has been hosted on [Google Sheets](https://docs.google.com/spreadsheets/d/1SYI_Gu6MAuSGw-OTXzk_FDWScx29Cc-6eXpc6UfSn1Y/edit?gid=1909841994#gid=1909841994) so far, but it should be more readable and open to collboration here.
