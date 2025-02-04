﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public ConsoleLogger Logger = new ConsoleLogger();
        public FilePolicySource FilePolicySource = new FilePolicySource();
        public JsonPolicyDeserialilzer PolicyDeserialilzer = new JsonPolicyDeserialilzer();
        public decimal Rating { get; set; }

        public void Rate()
        {
            Logger.Log("Starting rate.");
            Logger.Log("Loading policy.");

            string policyJson = FilePolicySource.GetFilePolictyFromSource("policy.json");
            var policy = PolicyDeserialilzer.GetDeserializePolicy(policyJson);

            var factory = new RaterFactory();

            var rater = factory.Create(policy, this);
            rater?.Rate(policy);

            Logger.Log("Rating completed.");
        }
    }
}
