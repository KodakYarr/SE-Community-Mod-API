﻿/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
 * This file is intended to contains all exception classes of the API
 * They must inheritate from IExceptionState and must retain the form
 * of GameInstallationExceptionInfo for standardisation.
 * 
 * */
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using SEModAPI.Support;

namespace SEModAPI.API
{
    #region "GameInstallationException"
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Enum to define state of Exceptions used into GameInstallation.cs
    /// </summary>
    public enum GameInstallationInfoExceptionState
    {
        Invalid,
		EmptyGamePath,
        GamePathNotFound,
        GameNotRegistered,
        SteamPathNotFound,
        SteamNotRegistered,
        BrokenGameDirectory,
        ConfigFileCorrupted,
        ConfigFileMissing,
        ConfigFileEmpty
    };
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// ExceptionInfo used into GameInstallation.cs and ConfigFileSerializer.cs
    /// </summary>
    public class GameInstallationInfoException : AutoException
    {
		public GameInstallationInfoException(GameInstallationInfoExceptionState state, string additionnalInfo = "") : base(state, additionnalInfo) { }

        public new string[] StateRepresentation =
        {
            "Invalid",
			"EmptyGamePath",
            "GamePathNotFound",
            "GameNotRegistered",
            "SteamPathNotFound",
            "SteamNotRegistered",
            "BrokenGameDirectory",
            "ConfigFileCorrupted",
            "ConfigFileMissing",
            "ConfigFileEmpty"
        };
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    #endregion

	#region "SEConfigurationException"
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Enum to define state of Exceptions used into GameInstallation.cs
	/// </summary>
	public enum SEConfigurationExceptionState
	{
		InvalidDefaultConfigFileName,
		InvalidConfigurationFile,
		InvalidFileInfo
	};
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>
	/// ExceptionInfo used into GameInstallation.cs and ConfigFileSerializer.cs
	/// </summary>
	public class SEConfigurationException : AutoException
	{
		public SEConfigurationException(SEConfigurationExceptionState state, string additionnalInfo = "") : base(state, additionnalInfo) { }

		public new string[] StateRepresentation =
        {
            "InvalidDefaultConfigFileName",
			"InvalidConfigurationFile",
			"InvalidFileInfo"
        };
	}
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	#endregion
}
