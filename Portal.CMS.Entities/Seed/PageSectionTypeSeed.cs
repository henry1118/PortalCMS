﻿using Portal.CMS.Entities.Entities.PageBuilder;
using System.Linq;

namespace Portal.CMS.Entities.Seed
{
    public class PageSectionTypeSeed
    {
        public static void Seed(PortalEntityModel context)
        {
            if (!context.PageSectionTypes.Any(x => x.PageSectionTypeName == "Introduction"))
            {
                context.PageSectionTypes.Add(new PageSectionType { PageSectionTypeName = "Introduction", PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"header background-parallax height-tall\"><div class=\"overlay-medium\"></div><div id=\"component-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container\"><h1 id=\"title-<sectionId>\" data-section=\"1\">Custom Page</h1><p id=\"subtitle-<sectionId>\">This is copy that can be updated and changed.</p></div></section>" });
            }

            if (!context.PageSectionTypes.Any(x => x.PageSectionTypeName == "Empty Section"))
            {
                context.PageSectionTypes.Add(new PageSectionType { PageSectionTypeName = "Empty Section", PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static\" style=\"background-size: contain;\"></section>" });
            }

            if (!context.PageSectionTypes.Any(x => x.PageSectionTypeName == "Block Text"))
            {
                context.PageSectionTypes.Add(new PageSectionType { PageSectionTypeName = "Block Text", PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"block block-text height-tiny\"><h1 id=\"title-<sectionId>\">Call for a Quote</h1><h1 id=\"subtitle-<sectionId>\">00000 000 000</h1></section>" });
            }

            if (!context.PageSectionTypes.Any(x => x.PageSectionTypeName == "Quote"))
            {
                context.PageSectionTypes.Add(new PageSectionType { PageSectionTypeName = "Quote", PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"quote\"><div class=\"quote-image-left\"></div><div class=\"quote-image-right\"></div><div id=\"container-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container\"><h1 id=\"quote-<componentStamp>-<sectionId>\">Perfection is not attainable, but if we chase perfection we can catch.</h1><p id=\"component-<componentStamp>-<sectionId>\">Tom McClean</p></div></section>" });
            }

            if (!context.PageSectionTypes.Any(x => x.PageSectionTypeName == "Basic Split Section"))
            {
                context.PageSectionTypes.Add(new PageSectionType { PageSectionTypeName = "Basic Split Section", PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static\" style=\"background-size: contain;\"><h1 id=\"title-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h1><p id=\"subtitle-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><div id=\"component-<componentStamp>-<sectionId>\" class=\"container component-container\"><div id=\"row-<componentStamp>-<sectionId>\" class=\"row component-container\"><div id=\"group-1-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 component-container\"><div id=\"image-1-<componentStamp>-<sectionId>\" class=\"image image-standard\"></div><h4 id=\"title-1-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"subtitle-1-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><a id=\"button-1-<componentStamp>-<sectionId>\" href=\"#\" class=\"btn\">Click me to find out more.</a></div><div id=\"group-2-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 component-container\"><div id=\"image-2-<componentStamp>-<sectionId>\" class=\"image image-standard\"></div><h4 id=\"title-2-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"subtitle-2-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><a id=\"button-2-<componentStamp>-<sectionId>\" href=\"#\" class=\"btn\">Click me to find out more.</a></div></div></div></section>" });
            }
        }
    }
}