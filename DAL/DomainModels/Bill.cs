using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainModels
{
    /*CREATE TABLE `Bill` (
    `id` VARCHAR(191) NOT NULL,
    `createdAt` DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
    `expiresAt` DATETIME(3) NOT NULL,
    `status` ENUM('CREATED', 'PAID', 'CANCELLED', 'EXPIRED') NOT NULL DEFAULT 'CREATED',
    `amount` DECIMAL(65, 30) NOT NULL,
    `commission` BOOLEAN NOT NULL DEFAULT true,
    `paymentSystem` ENUM('QiwiP2P', 'QiwiDirect', 'QiwiCard', 'YooMoney', 'Card') NULL,
    `successURL` VARCHAR(191) NOT NULL,
    `failURL` VARCHAR(191) NOT NULL,
    `webhookURL` VARCHAR(191) NULL,

    PRIMARY KEY (`id`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;*/
    public class Bill
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpiresAt { get; set; }

        public StatusEnum Status { get; set; }

        public double Amount { get; set; }

        public bool Commision { get; set; }

        public PaymentSystemEnum PaymentSystem { get; set; }

        public string SuccessUrl { get; set; }

        public string FailUrl { get; set; }

        public string WebhookURL { get; set; }

        //FK
        public List<Payment> Payments { get; set; } = new();
    }

    public enum StatusEnum
    {
        CREATED,
        PAID,
        CANCELLED,
        EXPIRED
    }
}
