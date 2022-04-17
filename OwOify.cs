using System;
using System.Collections.Generic;
using System.Linq;

namespace OwO;

public class OwOify
{
    public string Commence(string input)
    {
        return $"{GetRandomPrefix()} {Convert(input)} {GetRandomSuffix()}";
    }
    
    public string Translate(string input)
    {
        return Convert(input);
    }

    private string Convert(string input)
    {
        return _substitutions.Keys.ToList()
            .Aggregate(input, (current, replacement) => current
                .Replace(replacement, _substitutions[replacement]));
    }

    private string GetRandomPrefix()
    {
        return _prefixes[new Random().Next(0, _prefixes.Length - 1)];
    }

    private string GetRandomSuffix()
    {
        return _suffixes[new Random().Next(0, _suffixes.Length - 1)];
    }
    
    #region Lists
    
    private readonly string[] _prefixes = {
        "<3 ",
        "0w0 ",
        "H-hewwo?? ",
        "HIIII! ",
        "Haiiii! ",
        "Huohhhh. ",
        "OWO ",
        "OwO ",
        "UwU ",
    };

    private readonly string[] _suffixes =
    {
        " ( ´•̥̥̥ω•̥̥̥` )",
        " ( ˘ ³˘)♥",
        " ( ͡° ᴥ ͡°)",
        " (^³^)",
        " (´・ω・｀)",
        " (ʘᗩʘ\')",
        " (இωஇ )",
        " (๑•́ ₃ •̀๑)",
        " (• o •)",
        " (⁎˃ᆺ˂)",
        " (╯﹏╰）",
        " (●´ω｀●)",
        " (◠‿◠✿)",
        " (✿ ♡‿♡)",
        " (❁´◡`❁)",
        " (　\\'◟ \\')",
        " (人◕ω◕)",
        " (；ω；)",
        " (｀へ´)",
        " ._.",
        " :3",
        " :3c",
        " :D",
        " :O",
        " :P",
        " ;-;",
        " ;3",
        " ;_;",
        " <{^v^}>",
        " >_<",
        " >_>",
        " UwU",
        " XDDD",
        " \\°○°/",
        " ^-^",
        " ^_^",
        " x3",
        " x3",
        " xD",
        " ÙωÙ",
        " ʕʘ‿ʘʔ",
        " ʕ•ᴥ•ʔ",
        " ミ(．．)ミ",
        " ㅇㅅㅇ",
        ", fwendo",
        "（＾ｖ＾）",
    };

    private readonly Dictionary<string, string> _substitutions = new()
    {
        { "r", "w" },
        { "l", "w" },
        { "R", "W" },
        { "L", "W" },
        { "no", "nu" },
        { "has", "haz" },
        { "have", "haz" },
        { " says", " sez" },
        { "you", "uu" },
        { "the ", "da " },
        { "The ", "Da " },
        { "THE ", "THE " },
    };
    
    #endregion
}