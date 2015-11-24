using System.IO;

namespace IdSharp.Tagging.ID3v2
{
    /// <summary>
    /// Creates IID3v2Tag instances.
    /// </summary>
    public interface IID3v2TagFactory
    {
        /// <summary>
        /// Creates a new tag.
        /// </summary>
        IID3v2Tag Create();

        /// <summary>
        /// Reads an existing tag.
        /// </summary>
        /// <param name="path">The full path of the file.</param>
        IID3v2Tag Create(string path);

        /// <summary>
        /// Reads an existing tag.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        IID3v2Tag Create(Stream stream);
    }
}