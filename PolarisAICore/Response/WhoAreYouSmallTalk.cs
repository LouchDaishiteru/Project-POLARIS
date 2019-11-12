﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PolarisAICore.Response {
    class WhoAreYouSmallTalk {
        static readonly Random _random = new Random();

        static readonly String[] _noEntityResponses =
        {
            "I'm Polaris, the star that marks the north celestial pole.",
            "I'm the brightest star in the constelation of Ursa Minor, Polaris.",
            "Actually, I'm a Star. I work as a Personal Assistant just in my free hours.",
            "I'm Polaris, yours truly Personal Assistant."
        };

        public static String SetResponse(Utterance u) {
            
            return _noEntityResponses[_random.Next(_noEntityResponses.Length)];
        }
    }
}
