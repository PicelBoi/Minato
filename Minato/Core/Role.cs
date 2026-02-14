namespace Minato.Core;

// Covers roles.

public class Role
{
    public Guid Guid { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = "New Role";

    public string Color { get; set; } = "#87ceeb";

    // Unless set, these will be the default permissions for a new role.
    // How permissions are done is inspired by how Discord stores permissions, via
    // OR to generate one int to store all permissions, and AND to check if
    // the permission is set.
    public int Permissions { get; set; } = PermissionMethods.PermissionCalc(
        Core.Permissions.READ_MESSAGES,
        Core.Permissions.WRITE_MESSAGES,
        Core.Permissions.READ_MESSAGE_HISTORY,
        Core.Permissions.EDIT_MESSAGES,
        Core.Permissions.DELETE_MESSAGES,
        Core.Permissions.REPLY_MESSAGES,
        Core.Permissions.USE_EMOJI,
        Core.Permissions.CREATE_REACTION,
        Core.Permissions.MENTION_USER,
        Core.Permissions.CHANGE_DISPLAYNAME,
        Core.Permissions.CHANGE_BIO,
        Core.Permissions.CHANGE_PRONOUN,
        Core.Permissions.UPLOAD_FILE,
        Core.Permissions.EMBED_MEDIA
    );
}