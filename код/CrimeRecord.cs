using System;

namespace YourNamespace
{
    public class CrimeRecord
    {
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string Nickname
        {
            get; set;
        }
        public int? Height
        {
            get; set;
        }
        public string EyeColor
        {
            get; set;
        }
        public string Nationality
        {
            get; set;
        }
        public DateTime? BirthDate
        {
            get; set;
        }
        public string BirthPlace
        {
            get; set;
        }
        public string LastKnownAddress
        {
            get; set;
        }
        public string CriminalProfession
        {
            get; set;
        }
        public string HairColor
        {
            get; set;
        }
        public string DistinguishingMarks
        {
            get; set;
        }


        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName} ({Nickname}), Height: {Height}, Eye Color: {EyeColor}, " +
                   $"Nationality: {Nationality}, Birth Date: {BirthDate}, Birth Place: {BirthPlace}, " +
                   $"Last Known Address: {LastKnownAddress}, Profession: {CriminalProfession}, Hair Color: {HairColor}, " +
                   $"Distinguishing Marks: {DistinguishingMarks}";
        }

        public bool Matches(CrimeRecord criteria)
        {
            if (criteria == null) return false;

            if (!string.IsNullOrWhiteSpace(criteria.FirstName) && (FirstName == null || !FirstName.Contains(criteria.FirstName))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.LastName) && (LastName == null || !LastName.Contains(criteria.LastName))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.Nickname) && (Nickname == null || !Nickname.Contains(criteria.Nickname))) return false;
            if (criteria.Height.HasValue && Height != criteria.Height) return false;
            if (!string.IsNullOrWhiteSpace(criteria.EyeColor) && (EyeColor == null || !EyeColor.Contains(criteria.EyeColor))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.Nationality) && (Nationality == null || !Nationality.Contains(criteria.Nationality))) return false;
            if (criteria.BirthDate.HasValue && BirthDate != criteria.BirthDate) return false;
            if (!string.IsNullOrWhiteSpace(criteria.BirthPlace) && (BirthPlace == null || !BirthPlace.Contains(criteria.BirthPlace))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.LastKnownAddress) && (LastKnownAddress == null || !LastKnownAddress.Contains(criteria.LastKnownAddress))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.CriminalProfession) && (CriminalProfession == null || !CriminalProfession.Contains(criteria.CriminalProfession))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.HairColor) && (HairColor == null || !HairColor.Contains(criteria.HairColor))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.DistinguishingMarks) && (DistinguishingMarks == null || !DistinguishingMarks.Contains(criteria.DistinguishingMarks))) return false;

            return true;
        }

    }
}