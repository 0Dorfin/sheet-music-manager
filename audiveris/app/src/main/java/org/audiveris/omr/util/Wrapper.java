//------------------------------------------------------------------------------------------------//
//                                                                                                //
//                                         W r a p p e r                                          //
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
package org.audiveris.omr.util;

/**
 * Class <code>Wrapper</code> is used to wrap a mutable input value
 *
 * @param <T> The specific type for carried value
 * @author Hervé Bitteur
 */
public class Wrapper<T>
{
    //~ Instance fields ----------------------------------------------------------------------------

    /** The wrapped value. */
    public T value;

    //~ Constructors -------------------------------------------------------------------------------

    /**
     * Creates a new <code>Wrapper</code> object.
     *
     * @param value underlying value
     */
    public Wrapper (T value)
    {
        this.value = value;
    }

    //~ Methods ------------------------------------------------------------------------------------

    //----------//
    // toString //
    //----------//
    @Override
    public String toString ()
    {
        return "wrapper(" + value + ")";
    }
}
