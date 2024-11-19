# InteractiveCursor

`InteractiveCursor` is a Unity script that creates a custom UI cursor, which follows the mouse position and scales down on click, with the pivot point set to the top-left corner.

## Description

This script replaces the system cursor with a custom sprite and adds interactive behavior, making it ideal for recording creative videos for advertisements. The animated cursor enhances the visual appeal and user experience in promotional content.

## How to Use

1. Add a `Canvas` to your scene and create a `UI Image` within it for your cursor sprite.
2. Drag and drop the `InteractiveCursor` script onto the `UI Image` object.
3. Assign your sprite to the `Image` component and link it to the `cursorImage` field in the script's `Inspector`.
4. Run the scene to see the cursor animation and interaction in action.

## Parameters

- **cursorImage**: The `Image` component used for the cursor sprite.
- **clickScaleFactor**: The scale factor applied to shrink the cursor on click.

## Why Use This Script

This script is particularly useful for developers and content creators who need to record high-quality ad creatives. It adds a polished, animated cursor effect that can make your UI interactions more engaging and professional in videos.
