#region Using Directives

using StellarWolf.Core;
using UnityEngine;
using UnityEditor;

#endregion

namespace StellarWolf.CoreEditor
{
    /// <summary>
    /// Property Drawer for Dice
    /// </summary>
    [CustomPropertyDrawer ( typeof ( Dice ) )]
    public class DicePropertyDrawer : PropertyDrawer
    {

        /// <inheritdoc/>
        public override float GetPropertyHeight ( SerializedProperty property, GUIContent label ) => EditorGUIUtility.singleLineHeight;

        /// <inheritdoc/>
        public override void OnGUI ( Rect position, SerializedProperty property, GUIContent label )
        {

            position = EditorGUI.PrefixLabel ( position, label );

            position.width = ( position.width - EditorGUIUtility.standardVerticalSpacing ) * 0.5f;
            /* fixes indentation problems with custom property drawers.
             * adjusts the position to undo indentation after prefixing a label.
             */
            position.x -= EditorGUI.indentLevel * 15;
            position.width += EditorGUI.indentLevel * 15;

            _ = EditorGUI.PropertyField ( position, property.FindPropertyRelative ( "m_Count" ), GUIContent.none );
            position.x += position.width - ( EditorGUI.indentLevel * 15 ); // fixes horizontal indentation problems with custom property drawers.
            _ = EditorGUI.PropertyField ( position, property.FindPropertyRelative ( "m_Type" ), GUIContent.none );

        }

    }

}
