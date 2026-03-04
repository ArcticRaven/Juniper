namespace Juniper.Core.Contacts;

public enum Relationship
{
    // Immediate family
    Wife,
    Husband,
    Partner,
    Mother,
    Father,
    Parent,
    Daughter,
    Son,
    Child,
    Sibling,

    // Extended family
    Grandparent,
    Grandchild,
    Aunt,
    Uncle,
    Cousin,
    Relative,

    // Romantic
    Girlfriend,
    Boyfriend,
    Fiancé,
    Fiancée,
    Spouse,
    Situationship,

    // Social
    BestFriend,
    Friend,
    Acquaintance,
    Neighbor,

    // Work
    Coworker,
    Manager,
    Employee,
    Client,
    Contractor,
    BusinessPartner,

    // Misc
    EmergencyContact,
    Caregiver,
    Doctor,
    ServiceProvider,

    // Unknown / fallback
    Adjacent,
    Unknown
}