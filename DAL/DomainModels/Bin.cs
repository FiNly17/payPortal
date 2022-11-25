using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainModels
{
    /*CREATE TABLE `Bin` (
    `value` VARCHAR(6) NOT NULL,
    `paymentSystem` ENUM('VISA', 'MasterCard', 'MIR', 'AmericanExpress', 'Discover', 'UnionPay') NOT NULL,
    `bank` VARCHAR(191) NOT NULL,
    `countryCode` VARCHAR(2) NOT NULL,

    PRIMARY KEY (`value`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;*/
    public class Bin
    {
        [Key]
        public string Value { get; set; }

        public CardPaymentSystemEnum CardPaymentSystem { get; set; }

        public string Bank { get; set; }

        public string CountryCode { get; set; }
    }

    public enum CardPaymentSystemEnum
    {
        Visa,
        MasterCard,
        MIR,
        AmericanExpress,
        Discover,
        UnionPay
    }
}
