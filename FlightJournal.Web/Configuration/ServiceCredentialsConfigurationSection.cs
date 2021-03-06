﻿using System.Configuration;

namespace FlightJournal.Web.Configuration
{
    public class ServiceCredentialsConfigurationSection : ConfigurationSection
    {
        private ServiceCredentialsConfigurationSection() { }

        [ConfigurationProperty("FacebookAppId", DefaultValue = "")]
        public string FacebookAppId
        {
            get { return (string)this["FacebookAppId"]; }
            set { this["FacebookAppId"] = value; }
        }

        [ConfigurationProperty("FacebookAppSecret", DefaultValue = "")]
        public string FacebookAppSecret
        {
            get { return (string)this["FacebookAppSecret"]; }
            set { this["FacebookAppSecret"] = value; }
        }

        [ConfigurationProperty("GoogleClientId", DefaultValue = "")]
        public string GoogleClientId
        {
            get { return (string)this["GoogleClientId"]; }
            set { this["GoogleClientId"] = value; }
        }

        [ConfigurationProperty("GoogleClientSecret", DefaultValue = "")]
        public string GoogleClientSecret
        {
            get { return (string)this["GoogleClientSecret"]; }
            set { this["GoogleClientSecret"] = value; }
        }

        [ConfigurationProperty("TwilioAccountSid", DefaultValue = "")]
        public string TwilioAccountSid
        {
            get { return (string)this["TwilioAccountSid"]; }
            set { this["TwilioAccountSid"] = value; }
        }
        
        [ConfigurationProperty("TwilioAuthToken", DefaultValue = "")]
        public string TwilioAuthToken
        {
            get { return (string)this["TwilioAuthToken"]; }
            set { this["TwilioAuthToken"] = value; }
        }

        [ConfigurationProperty("TwilioFromNumber", DefaultValue = "")]
        public string TwilioFromNumber
        {
            get { return (string)this["TwilioFromNumber"]; }
            set { this["TwilioFromNumber"] = value; }
        }
    }
}