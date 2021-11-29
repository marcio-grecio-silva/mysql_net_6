using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNet6MysqlNew.Models
{
    [Table("service_stats")]
    public class ServiceStats
    {
        [Key]
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public long MessageId { get; set; }
        public long ProviderId { get; set; }
        public string EventDate { get; set; }
        public string Event { get; set; }
        public string EventType { get; set; }
        public string MessageType { get; set; }
        public string From { get; set; }
        public string ReactionTime { get; set; }
        public string Client { get; set; }
        public string ProviderType { get; set; }
        public string ServiceQueueName { get; set; }
        public string UserStatus { get; set; }

    }
}