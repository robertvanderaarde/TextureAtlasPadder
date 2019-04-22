### About

Texture Atlas Padder was built to create texture atlases that support pixel padding. This is useful for using a texture atlas for terrain generation. The reason the padding is necessary is that when creating mip maps for the textures, without the padding there is often bleeding on the texture atlas.

### How to use

The add image button is used to add a singular image to the project. In the bottom right you can see the texture atlas options. The padding is the amount in pixels, the rows & columns define how many textures can go in the atlas. The Image Size X & Y will automatically resize each added image to the texture and pad that.

The Texture ID is what determines the position of the texture on the atlas. It is row major, so for example if you have 3 columns, the textures will be placed as so by ID:

    	0, 1, 2, 
    	3, 4, 5,
    	6, 7, 8

# Download
[Version 1.0](https://www.dropbox.com/s/uxfdfduoa229j1j/TextureAtlasPadder.zip?dl=1 "Version 1.0")

### PS
Sorry for the terrible code
