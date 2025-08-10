using System.Collections.Generic;

namespace YarnSpinner.YarnSpinner.Markup
{

#pragma warning disable CA1815

    /// <summary>
    /// Container giving additionnal informations
    /// markup replacement and offset correction.
    /// </summary>
    public class SharedMarkupsMeta
    {

        /// <summary>
        /// Markups meta of a line.
        /// </summary>
        public List<MarkupMeta> MarkupsMeta { get; }

        /// <summary>
        /// Represents meta of markup (open and closed tag included.)
        /// </summary>
        public readonly struct MarkupMeta
        {

            /// <summary>
            /// Beginning markup position
            /// </summary>
            public int MarkupPosition { get; }

            /// <summary>
            /// Total length of markup
            /// </summary>
            public int MarkupLength { get; }

            /// <summary>
            /// Initialize markup meta
            /// </summary>
            /// <param name="markupPosition"></param>
            /// <param name="markupLength"></param>
            public MarkupMeta(int markupPosition, int markupLength)
            {
                MarkupPosition = markupPosition;
                MarkupLength = markupLength;
            } 
        }

        /// <summary>
        /// Make a new meta container.
        /// </summary>
        public SharedMarkupsMeta()
        {
            MarkupsMeta = new();
        }
    }
}
