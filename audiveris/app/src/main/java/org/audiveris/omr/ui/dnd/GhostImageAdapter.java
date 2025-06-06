//------------------------------------------------------------------------------------------------//
//                                                                                                //
//                               G h o s t I m a g e A d a p t e r                                //
//                                                                                                //
//------------------------------------------------------------------------------------------------//
// <editor-fold defaultstate="collapsed" desc="hdr">
//
//  Copyright © Audiveris 2025. All rights reserved.
//
//  This program is free software: you can redistribute it and/or modify it under the terms of the
//  GNU Affero General Public License as published by the Free Software Foundation, either version
//  3 of the License, or (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
//  without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
//  See the GNU Affero General Public License for more details.
//
//  You should have received a copy of the GNU Affero General Public License along with this
//  program.  If not, see <http://www.gnu.org/licenses/>.
//------------------------------------------------------------------------------------------------//
// </editor-fold>
package org.audiveris.omr.ui.dnd;

import java.awt.image.BufferedImage;

/**
 * Class <code>GhostImageAdapter</code> is a {@link GhostDropAdapter} with a provided image.
 *
 * @param <A> The precise type of action carried by the drop
 * @author Hervé Bitteur (from Romain Guy's demo)
 */
public class GhostImageAdapter<A>
        extends GhostDropAdapter<A>
{
    //~ Constructors -------------------------------------------------------------------------------

    /**
     * Create a new GhostImageAdapter object
     *
     * @param glassPane the related glasspane
     * @param action    the carried action
     * @param image     the provided image
     */
    public GhostImageAdapter (GhostGlassPane glassPane,
                              A action,
                              BufferedImage image)
    {
        super(glassPane, action);

        this.image = image;
    }
}
