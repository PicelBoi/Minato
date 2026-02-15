namespace Minato.Core;

// Covers permissions.

public enum Permissions : int
{
    // Messages
    READ_MESSAGES = 0x001,
    WRITE_MESSAGES = 0x002,
    EDIT_MESSAGES = 0x003,
    EDIT_OTHER_MESSAGES = 0x004,
    REPLY_MESSAGES = 0x005,
    DELETE_MESSAGES = 0x006,
    DELETE_OTHER_MESSAGES = 0x007,
    READ_MESSAGE_HISTORY = 0x008,
    // Channels
    CREATE_CHANNELS = 0x101,
    EDIT_CHANNELS = 0x102,
    DELETE_CHANNELS = 0x103,
    // Reactions
    CREATE_REACTION = 0x204,
    REMOVE_REACTION = 0x205,
    // Emojis
    CREATE_EMOJI = 0x301,
    DELETE_EMOJI = 0x306,
    EDIT_EMOJI = 0x307,
    USE_EMOJI = 0x308,
    // Moderation
    TIMEOUT_USER = 0x401,
    WARN_USER = 0x402,
    KICK_USER = 0x403,
    BAN_USER = 0x404,
    // User
    CHANGE_DISPLAYNAME = 0x501,
    CHANGE_OTHER_DISPLAYNAME = 0x502,
    CHANGE_BIO = 0x503,
    CHANGE_PRONOUN = 0x504,
    // Mentions
    MENTION_USER = 0x601,
    MENTION_EVERYONE = 0x602,
    // Files
    UPLOAD_FILE = 0x701,
    DELETE_FILE = 0x702,
    DELETE_OTHER_FILE = 0x703,
    EMBED_MEDIA = 0x704,
    SET_QUOTA = 0x705,
    // Server
    EDIT_SERVER = 0x801

}

public static class PermissionMethods
{
    public static bool PermissionCheck(int[] psarray, int permtocheck)
    {
        List<int> hasPerms = [];
        // Convert values into int.
        IEnumerable<int> intPerms = Enum.GetValues<Permissions>().Select(perm => (int)perm);
        foreach (int permissions in psarray)
        {
            foreach (int permission in intPerms)
            {
                if (!hasPerms.Contains(permission))
                {
                    if ((permissions & permission) == permission)
                    {
                        if (permission == permtocheck)
                        {
                            return true;
                        }
                        else
                        {
                            hasPerms.Add(permission);
                        }
                    }
                }
            }
        }

        // If permission check fails, return false.
        return false;
    }

    public static int PermissionCalc(params Permissions[] parray)
    {
        int permissions = 0x0;
        foreach (Permissions permission in parray)
        {
            permissions |= (int)permission;
        }

        return permissions;
    }
}
