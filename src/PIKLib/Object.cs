namespace abstractions;

public abstract class OBJECT {
    /// <summary>
    /// A short description of the object.
    /// </summary>
    public string? DESCRIPTION { private get; init; }

    /// <summary>
    /// The type of the object.
    /// </summary>
    public string TYPE { private get; init; }

    /// <summary>
    /// Adds/overwrites a handler for the given signal.
    /// </summary>
    /// <param name="signal_name">The (parametrized) name of the signal.</param>
    /// <param name="code">A handler (code block or a BEHAVIOUR name).</param>
    public void ADDBEHAVIOUR(string signal_name, string code) { throw new NotImplementedException(); }

    /// <summary>
    /// Sets the clone count for the object. If it is greater than current clone count, new clones are created.
    /// </summary>
    /// <param name="count">Desired clone count.</param>
    public void CLONE(int count = 1) { throw new NotImplementedException(); }

    /// <summary>
    /// Returns the clone index of the object.
    /// </summary>
    /// <returns>0 if the object is the original, unique sequential 1-based index otherwise.</returns>
    public int GETCLONEINDEX() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the name of the object.
    /// </summary>
    /// <returns>The object name.</returns>
    public string GETNAME() { throw new NotImplementedException(); }

    /// <summary>
    /// Displays a message box with the given contents.
    /// </summary>
    /// <remarks>
    /// Does nothing in the release build of the original engine.
    /// </remarks>
    /// <param name="message">A message to be displayed.</param>
    public void MSGBOX(string message) { throw new NotImplementedException(); }

    /// <summary>
    /// Removes the handler for the given signal (if it exists).
    /// </summary>
    /// <param name="signal_name">The (parametrized) name of the signal.</param>
    // TODO: does it remove handlers set when declaring the object and not added using ADDBEHAVIOUR?
    public void REMOVEBEHAVIOUR(string signal_name) { throw new NotImplementedException(); }

    /// <summary>
    /// Resets the clone count.
    /// </summary>
    // TODO: are the clones removed?
    public void RESETCLONES() { throw new NotImplementedException(); }
}
