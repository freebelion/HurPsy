namespace HurPsyExp
{
    /// <summary>
    /// This enumeration is for switching the main Design Window layout at runtime.
    /// It is used on the **Layout** menu on `DesignWindow`, but the commands from that menu are handled by the `AppSettings` instance.
    /// </summary>
    public enum LayoutChoice
    {
        /// <summary>
        /// The upper panel is for adding and editing items and the lower panel is for displaying the items
        /// </summary>
        SinglePanel,
        /// <summary>
        /// The right panel is for adding and editing items and the left panel is for displaying the items
        /// </summary>
        SplitPanel
    }

    /// <summary>
    /// This enumeration is for choosing the `MainContent` in `DesignViewModel`.
    /// It is used on the **MainContentMenu** which is defined in **DesignLayouts.xaml**.
    /// The menu commands are handled by the `DesignViewModel` instance.
    /// </summary>
    public enum ContentChoice
    {
        /// <summary>
        /// Stimulus definitions are to be displayed
        /// </summary>
        StimulusDefinitions,
        /// <summary>
        /// Locator definitions are to be displayed
        /// </summary>
        LocatorDefinitions
    }
}
