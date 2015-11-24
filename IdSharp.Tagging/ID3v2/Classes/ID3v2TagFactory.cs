using System.IO;

namespace IdSharp.Tagging.ID3v2
{
    /// <summary>
    /// Creates IID3v2Tag instances.
    /// </summary>
    public class ID3v2TagFactory : IID3v2TagFactory
    {
        /// <summary>
        /// Creates a new tag.
        /// </summary>
        public IID3v2Tag Create()
        {
            return new ID3v2Tag();
        }

        /// <summary>
        /// Reads an existing tag.
        /// </summary>
        /// <param name="path">The full path of the file.</param>
        public IID3v2Tag Create(string path)
        {
            return new ID3v2Tag(path);
        }

        /// <summary>
        /// Reads an existing tag.
        /// </summary>
        /// <param name="stream">The stream to read from.</param>
        public IID3v2Tag Create(Stream stream)
        {
            return new ID3v2Tag(stream);
        }
    }
}