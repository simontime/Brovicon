# Brovicon
An easy-to-use, free, broadcast-quality video converter which performs state-of-the-art deinterlacing, frame rate/standards conversion, upscaling and downscaling.

My motivation to develop this tool stems from my intense hatred of major record companies and their insistence on continuously defacating out these shitty, AI-upscaled, so-called "remasters" of music videos which were originally recorded to very high quality analogue videotape.

This tool takes any video file and preserves the original silky-smooth motion rate of 50/59.94 Hz, whilst also enabling you to convert the frame rate if needed, and can cleanly upscale the output to HD or 4K resolution (for YouTube, for example) without any nasty artefacts as produced by all the leading AI video upscaling tools.

Disclaimer: Please don't use the standards conversion feature for YouTube uploads: 50i in should be 50p out - YouTube can display PAL (50p) video just fine. Just because this tool lets you convert 50i videos to 59.94p doesn't mean you should! Preserve your 50i videos at 50p, and your 59.94i videos at 59.94p unless you explicitly need to convert between standards.

## Credits
- [FFmpeg](https://ffmpeg.org/)
- FFmpegSource: Myrsloik, et al.
- QTGMC by Vit, Dogway and real.finder, which leverages off:
- - DePan, DePanEstimate: Fizick, pinterf
- - FFT3DFilter: Fizick, martin53, pinterf
- - MaskTools2: pinterf, tp7, Manao, mg262, Kurosu
- - MVTools: Manao, Fizick, Tsp, TSchniede, SEt, cretindesalpes, pinterf
- - NNEDI3: tritical, jpsdr
- - RgTools: tp7, pinterf
- - Zs_RF_Shared: real.finder, et al.
- [FFTW](http://www.fftw.org/)

FFmpeg, FFTW, and all included binaries necessary for QTGMC to function are licensed under [GPLv2](https://www.gnu.org/licenses/gpl-2.0.txt).
Massive thanks go out to everyone mentioned, without whom this project would not have been possible!
