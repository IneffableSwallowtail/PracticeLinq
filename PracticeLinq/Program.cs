using PracticeLinq;
using System.Linq;

string[] videoGames = new string[]
{
    "Little Big Planet",
    "Final Fantasy VII",
    "DOOM",
    "Hyper Light Drifter",
    "Shadow of the Colossus",
    "Ico",
    "Bendy and the Ink Machine",
    "Mother",
    "Cave Story",
    "Hollow Knight"
};

IEnumerable<string> sorted = videoGames.OrderBy(game => game.Length);
Methods.PrintEnumerable(sorted);