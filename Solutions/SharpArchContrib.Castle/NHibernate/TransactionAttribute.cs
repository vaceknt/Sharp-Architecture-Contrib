﻿namespace SharpArchContrib.Castle.NHibernate
{
    using System;

    using SharpArch.Domain;

    using SharpArchContrib.Data.NHibernate;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class TransactionAttribute : Attribute, ITransactionAttributeSettings
    {
        private TransactionAttributeSettings settings;

        public TransactionAttribute()
        {
            this.settings = new TransactionAttributeSettings();
        }

        public string FactoryKey
        {
            get
            {
                return this.Settings.FactoryKey;
            }

            set
            {
                if (value == null)
                {
                    throw new PreconditionException("FactoryKey cannot be null");
                }

                this.Settings.FactoryKey = value;
            }
        }

        public bool IsExceptionSilent
        {
            get
            {
                return this.Settings.IsExceptionSilent;
            }

            set
            {
                this.Settings.IsExceptionSilent = value;
            }
        }

        public object ReturnValue
        {
            get
            {
                return this.Settings.ReturnValue;
            }

            set
            {
                this.Settings.ReturnValue = value;
            }
        }

        public TransactionAttributeSettings Settings
        {
            get
            {
                return this.settings;
            }

            set
            {
                if (value == null)
                {
                    throw new PreconditionException("Settings must not be null");
                }

                this.settings = value;
            }
        }
    }
}