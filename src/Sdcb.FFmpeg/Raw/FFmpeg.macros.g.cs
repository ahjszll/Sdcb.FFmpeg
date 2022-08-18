using System;
using System.Runtime.InteropServices;

#pragma warning disable 169
#pragma warning disable CS0649
#pragma warning disable CS0108
namespace Sdcb.FFmpeg.Raw
{
    public unsafe static partial class ffmpeg
    {
        /// <summary>_WIN32_WINNT = 0x0602</summary>
        public const uint _WIN32_WINNT = 0x0602;
        // public static attribute_deprecated = __declspec(deprecated);
        // public static av_alias = __attribute__((may_alias));
        // public static av_alloc_size = (...);
        // public static av_always_inline = __forceinline;
        /// <summary>AV_BUFFER_FLAG_READONLY = (1 &lt;&lt; 0)</summary>
        public const int AV_BUFFER_FLAG_READONLY = (1 << 0);
        /// <summary>AV_BUFFERSINK_FLAG_NO_REQUEST = 2</summary>
        public const int AV_BUFFERSINK_FLAG_NO_REQUEST = 2;
        /// <summary>AV_BUFFERSINK_FLAG_PEEK = 1</summary>
        public const int AV_BUFFERSINK_FLAG_PEEK = 1;
        // public static av_builtin_constant_p = __builtin_constant_p;
        // public static av_ceil_log2 = av_ceil_log2_c;
        // public static AV_CEIL_RSHIFT = (a,b) (!av_builtin_constant_p(b) ? -((-(a)) >> (b)) : ((a) + (1<<(b)) - 1) >> (b));
        // public static AV_CHANNEL_LAYOUT_2_1 = AV_CHANNEL_LAYOUT_MASK(3,  AV_CH_LAYOUT_2_1);
        // public static AV_CHANNEL_LAYOUT_2_2 = AV_CHANNEL_LAYOUT_MASK(4,  AV_CH_LAYOUT_2_2);
        // public static AV_CHANNEL_LAYOUT_22POINT2 = AV_CHANNEL_LAYOUT_MASK(24, AV_CH_LAYOUT_22POINT2);
        // public static AV_CHANNEL_LAYOUT_2POINT1 = AV_CHANNEL_LAYOUT_MASK(3,  AV_CH_LAYOUT_2POINT1);
        // public static AV_CHANNEL_LAYOUT_3POINT1 = AV_CHANNEL_LAYOUT_MASK(4,  AV_CH_LAYOUT_3POINT1);
        // public static AV_CHANNEL_LAYOUT_4POINT0 = AV_CHANNEL_LAYOUT_MASK(4,  AV_CH_LAYOUT_4POINT0);
        // public static AV_CHANNEL_LAYOUT_4POINT1 = AV_CHANNEL_LAYOUT_MASK(5,  AV_CH_LAYOUT_4POINT1);
        // public static AV_CHANNEL_LAYOUT_5POINT0 = AV_CHANNEL_LAYOUT_MASK(5,  AV_CH_LAYOUT_5POINT0);
        // public static AV_CHANNEL_LAYOUT_5POINT0_BACK = AV_CHANNEL_LAYOUT_MASK(5,  AV_CH_LAYOUT_5POINT0_BACK);
        // public static AV_CHANNEL_LAYOUT_5POINT1 = AV_CHANNEL_LAYOUT_MASK(6,  AV_CH_LAYOUT_5POINT1);
        // public static AV_CHANNEL_LAYOUT_5POINT1_BACK = AV_CHANNEL_LAYOUT_MASK(6,  AV_CH_LAYOUT_5POINT1_BACK);
        // public static AV_CHANNEL_LAYOUT_6POINT0 = AV_CHANNEL_LAYOUT_MASK(6,  AV_CH_LAYOUT_6POINT0);
        // public static AV_CHANNEL_LAYOUT_6POINT0_FRONT = AV_CHANNEL_LAYOUT_MASK(6,  AV_CH_LAYOUT_6POINT0_FRONT);
        // public static AV_CHANNEL_LAYOUT_6POINT1 = AV_CHANNEL_LAYOUT_MASK(7,  AV_CH_LAYOUT_6POINT1);
        // public static AV_CHANNEL_LAYOUT_6POINT1_BACK = AV_CHANNEL_LAYOUT_MASK(7,  AV_CH_LAYOUT_6POINT1_BACK);
        // public static AV_CHANNEL_LAYOUT_6POINT1_FRONT = AV_CHANNEL_LAYOUT_MASK(7,  AV_CH_LAYOUT_6POINT1_FRONT);
        // public static AV_CHANNEL_LAYOUT_7POINT0 = AV_CHANNEL_LAYOUT_MASK(7,  AV_CH_LAYOUT_7POINT0);
        // public static AV_CHANNEL_LAYOUT_7POINT0_FRONT = AV_CHANNEL_LAYOUT_MASK(7,  AV_CH_LAYOUT_7POINT0_FRONT);
        // public static AV_CHANNEL_LAYOUT_7POINT1 = AV_CHANNEL_LAYOUT_MASK(8,  AV_CH_LAYOUT_7POINT1);
        // public static AV_CHANNEL_LAYOUT_7POINT1_WIDE = AV_CHANNEL_LAYOUT_MASK(8,  AV_CH_LAYOUT_7POINT1_WIDE);
        // public static AV_CHANNEL_LAYOUT_7POINT1_WIDE_BACK = AV_CHANNEL_LAYOUT_MASK(8,  AV_CH_LAYOUT_7POINT1_WIDE_BACK);
        // public static AV_CHANNEL_LAYOUT_AMBISONIC_FIRST_ORDER = { .order = AV_CHANNEL_ORDER_AMBISONIC, .nb_channels = 4, .u = { .mask = 0 }};
        // public static AV_CHANNEL_LAYOUT_HEXADECAGONAL = AV_CHANNEL_LAYOUT_MASK(16, AV_CH_LAYOUT_HEXADECAGONAL);
        // public static AV_CHANNEL_LAYOUT_HEXAGONAL = AV_CHANNEL_LAYOUT_MASK(6,  AV_CH_LAYOUT_HEXAGONAL);
        // public static AV_CHANNEL_LAYOUT_MASK = (nb, m) { .order = AV_CHANNEL_ORDER_NATIVE, .nb_channels = (nb), .u = { .mask = (m) }};
        // public static AV_CHANNEL_LAYOUT_MONO = AV_CHANNEL_LAYOUT_MASK(1,  AV_CH_LAYOUT_MONO);
        // public static AV_CHANNEL_LAYOUT_OCTAGONAL = AV_CHANNEL_LAYOUT_MASK(8,  AV_CH_LAYOUT_OCTAGONAL);
        // public static AV_CHANNEL_LAYOUT_QUAD = AV_CHANNEL_LAYOUT_MASK(4,  AV_CH_LAYOUT_QUAD);
        // public static AV_CHANNEL_LAYOUT_STEREO = AV_CHANNEL_LAYOUT_MASK(2,  AV_CH_LAYOUT_STEREO);
        // public static AV_CHANNEL_LAYOUT_STEREO_DOWNMIX = AV_CHANNEL_LAYOUT_MASK(2,  AV_CH_LAYOUT_STEREO_DOWNMIX);
        // public static AV_CHANNEL_LAYOUT_SURROUND = AV_CHANNEL_LAYOUT_MASK(3,  AV_CH_LAYOUT_SURROUND);
        // public static av_clip = av_clip_c;
        // public static av_clip_int16 = av_clip_int16_c;
        // public static av_clip_int8 = av_clip_int8_c;
        // public static av_clip_intp2 = av_clip_intp2_c;
        // public static av_clip_uint16 = av_clip_uint16_c;
        // public static av_clip_uint8 = av_clip_uint8_c;
        // public static av_clip_uintp2 = av_clip_uintp2_c;
        // public static av_clip64 = av_clip64_c;
        // public static av_clipd = av_clipd_c;
        // public static av_clipf = av_clipf_c;
        // public static av_clipl_int32 = av_clipl_int32_c;
        /// <summary>AV_CODEC_EXPORT_DATA_FILM_GRAIN = (1 &lt;&lt; 3)</summary>
        public const int AV_CODEC_EXPORT_DATA_FILM_GRAIN = (1 << 3);
        /// <summary>AV_CODEC_EXPORT_DATA_MVS = (1 &lt;&lt; 0)</summary>
        public const int AV_CODEC_EXPORT_DATA_MVS = (1 << 0);
        /// <summary>AV_CODEC_EXPORT_DATA_PRFT = (1 &lt;&lt; 1)</summary>
        public const int AV_CODEC_EXPORT_DATA_PRFT = (1 << 1);
        /// <summary>AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS = (1 &lt;&lt; 2)</summary>
        public const int AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS = (1 << 2);
        /// <summary>AV_CODEC_ID_H265 = AV_CODEC_ID_HEVC</summary>
        public static readonly int AV_CODEC_ID_H265 = AVCodecID.AV_CODEC_ID_HEVC;
        /// <summary>AV_CODEC_ID_H266 = AV_CODEC_ID_VVC</summary>
        public static readonly int AV_CODEC_ID_H266 = AVCodecID.AV_CODEC_ID_VVC;
        /// <summary>AV_CODEC_ID_IFF_BYTERUN1 = AV_CODEC_ID_IFF_ILBM</summary>
        public static readonly int AV_CODEC_ID_IFF_BYTERUN1 = AVCodecID.AV_CODEC_ID_IFF_ILBM;
        /// <summary>AV_CODEC_PROP_BITMAP_SUB = (1 &lt;&lt; 16)</summary>
        public const int AV_CODEC_PROP_BITMAP_SUB = (1 << 16);
        /// <summary>AV_CODEC_PROP_INTRA_ONLY = (1 &lt;&lt; 0)</summary>
        public const int AV_CODEC_PROP_INTRA_ONLY = (1 << 0);
        /// <summary>AV_CODEC_PROP_LOSSLESS = (1 &lt;&lt; 2)</summary>
        public const int AV_CODEC_PROP_LOSSLESS = (1 << 2);
        /// <summary>AV_CODEC_PROP_LOSSY = (1 &lt;&lt; 1)</summary>
        public const int AV_CODEC_PROP_LOSSY = (1 << 1);
        /// <summary>AV_CODEC_PROP_REORDER = (1 &lt;&lt; 3)</summary>
        public const int AV_CODEC_PROP_REORDER = (1 << 3);
        /// <summary>AV_CODEC_PROP_TEXT_SUB = (1 &lt;&lt; 17)</summary>
        public const int AV_CODEC_PROP_TEXT_SUB = (1 << 17);
        // public static av_cold = __attribute__((cold));
        // public static av_const = __attribute__((const));
        /// <summary>AV_DICT_APPEND = 32</summary>
        public const int AV_DICT_APPEND = 32;
        /// <summary>AV_DICT_DONT_OVERWRITE = 16</summary>
        public const int AV_DICT_DONT_OVERWRITE = 16;
        /// <summary>AV_DICT_DONT_STRDUP_KEY = 4</summary>
        public const int AV_DICT_DONT_STRDUP_KEY = 4;
        /// <summary>AV_DICT_DONT_STRDUP_VAL = 8</summary>
        public const int AV_DICT_DONT_STRDUP_VAL = 8;
        /// <summary>AV_DICT_IGNORE_SUFFIX = 2</summary>
        public const int AV_DICT_IGNORE_SUFFIX = 2;
        /// <summary>AV_DICT_MATCH_CASE = 1</summary>
        public const int AV_DICT_MATCH_CASE = 1;
        /// <summary>AV_DICT_MULTIKEY = 64</summary>
        public const int AV_DICT_MULTIKEY = 64;
        /// <summary>AV_DISPOSITION_ATTACHED_PIC = (1 &lt;&lt; 10)</summary>
        public const int AV_DISPOSITION_ATTACHED_PIC = (1 << 10);
        /// <summary>AV_DISPOSITION_CAPTIONS = (1 &lt;&lt; 16)</summary>
        public const int AV_DISPOSITION_CAPTIONS = (1 << 16);
        /// <summary>AV_DISPOSITION_CLEAN_EFFECTS = (1 &lt;&lt; 9)</summary>
        public const int AV_DISPOSITION_CLEAN_EFFECTS = (1 << 9);
        /// <summary>AV_DISPOSITION_COMMENT = (1 &lt;&lt; 3)</summary>
        public const int AV_DISPOSITION_COMMENT = (1 << 3);
        /// <summary>AV_DISPOSITION_DEFAULT = (1 &lt;&lt; 0)</summary>
        public const int AV_DISPOSITION_DEFAULT = (1 << 0);
        /// <summary>AV_DISPOSITION_DEPENDENT = (1 &lt;&lt; 19)</summary>
        public const int AV_DISPOSITION_DEPENDENT = (1 << 19);
        /// <summary>AV_DISPOSITION_DESCRIPTIONS = (1 &lt;&lt; 17)</summary>
        public const int AV_DISPOSITION_DESCRIPTIONS = (1 << 17);
        /// <summary>AV_DISPOSITION_DUB = (1 &lt;&lt; 1)</summary>
        public const int AV_DISPOSITION_DUB = (1 << 1);
        /// <summary>AV_DISPOSITION_FORCED = (1 &lt;&lt; 6)</summary>
        public const int AV_DISPOSITION_FORCED = (1 << 6);
        /// <summary>AV_DISPOSITION_HEARING_IMPAIRED = (1 &lt;&lt; 7)</summary>
        public const int AV_DISPOSITION_HEARING_IMPAIRED = (1 << 7);
        /// <summary>AV_DISPOSITION_KARAOKE = (1 &lt;&lt; 5)</summary>
        public const int AV_DISPOSITION_KARAOKE = (1 << 5);
        /// <summary>AV_DISPOSITION_LYRICS = (1 &lt;&lt; 4)</summary>
        public const int AV_DISPOSITION_LYRICS = (1 << 4);
        /// <summary>AV_DISPOSITION_METADATA = (1 &lt;&lt; 18)</summary>
        public const int AV_DISPOSITION_METADATA = (1 << 18);
        /// <summary>AV_DISPOSITION_NON_DIEGETIC = (1 &lt;&lt; 12)</summary>
        public const int AV_DISPOSITION_NON_DIEGETIC = (1 << 12);
        /// <summary>AV_DISPOSITION_ORIGINAL = (1 &lt;&lt; 2)</summary>
        public const int AV_DISPOSITION_ORIGINAL = (1 << 2);
        /// <summary>AV_DISPOSITION_STILL_IMAGE = (1 &lt;&lt; 20)</summary>
        public const int AV_DISPOSITION_STILL_IMAGE = (1 << 20);
        /// <summary>AV_DISPOSITION_TIMED_THUMBNAILS = (1 &lt;&lt; 11)</summary>
        public const int AV_DISPOSITION_TIMED_THUMBNAILS = (1 << 11);
        /// <summary>AV_DISPOSITION_VISUAL_IMPAIRED = (1 &lt;&lt; 8)</summary>
        public const int AV_DISPOSITION_VISUAL_IMPAIRED = (1 << 8);
        /// <summary>AV_EF_AGGRESSIVE = (1&lt;&lt;18)</summary>
        public const int AV_EF_AGGRESSIVE = (1 << 18);
        /// <summary>AV_EF_BITSTREAM = (1&lt;&lt;1)</summary>
        public const int AV_EF_BITSTREAM = (1 << 1);
        /// <summary>AV_EF_BUFFER = (1&lt;&lt;2)</summary>
        public const int AV_EF_BUFFER = (1 << 2);
        /// <summary>AV_EF_CAREFUL = (1&lt;&lt;16)</summary>
        public const int AV_EF_CAREFUL = (1 << 16);
        /// <summary>AV_EF_COMPLIANT = (1&lt;&lt;17)</summary>
        public const int AV_EF_COMPLIANT = (1 << 17);
        /// <summary>AV_EF_CRCCHECK = (1&lt;&lt;0)</summary>
        public const int AV_EF_CRCCHECK = (1 << 0);
        /// <summary>AV_EF_EXPLODE = (1&lt;&lt;3)</summary>
        public const int AV_EF_EXPLODE = (1 << 3);
        /// <summary>AV_EF_IGNORE_ERR = (1&lt;&lt;15)</summary>
        public const int AV_EF_IGNORE_ERR = (1 << 15);
        // public static av_err2str = (errnum) av_make_error_string((char[AV_ERROR_MAX_STRING_SIZE]){0}, AV_ERROR_MAX_STRING_SIZE, errnum);
        /// <summary>AV_ERROR_MAX_STRING_SIZE = 64</summary>
        public const int AV_ERROR_MAX_STRING_SIZE = 64;
        // public static av_extern_inline = inline;
        /// <summary>AV_FOURCC_MAX_STRING_SIZE = 32</summary>
        public const int AV_FOURCC_MAX_STRING_SIZE = 32;
        // public static av_fourcc2str = (fourcc) av_fourcc_make_string((char[AV_FOURCC_MAX_STRING_SIZE]){0}, fourcc);
        /// <summary>AV_FRAME_FILENAME_FLAGS_MULTIPLE = 1</summary>
        public const int AV_FRAME_FILENAME_FLAGS_MULTIPLE = 1;
        /// <summary>AV_FRAME_FLAG_CORRUPT = (1 &lt;&lt; 0)</summary>
        public const int AV_FRAME_FLAG_CORRUPT = (1 << 0);
        /// <summary>AV_FRAME_FLAG_DISCARD = (1 &lt;&lt; 2)</summary>
        public const int AV_FRAME_FLAG_DISCARD = (1 << 2);
        // public static AV_GCC_VERSION_AT_LEAST = (x,y) 0;
        // public static AV_GCC_VERSION_AT_MOST = (x,y)  0;
        /// <summary>AV_GET_BUFFER_FLAG_REF = (1 &lt;&lt; 0)</summary>
        public const int AV_GET_BUFFER_FLAG_REF = (1 << 0);
        /// <summary>AV_GET_ENCODE_BUFFER_FLAG_REF = (1 &lt;&lt; 0)</summary>
        public const int AV_GET_ENCODE_BUFFER_FLAG_REF = (1 << 0);
        // public static AV_GLUE = (a, b) a ## b;
        // public static AV_HAS_BUILTIN = (x) __has_builtin(x);
        /// <summary>AV_HAVE_BIGENDIAN = 0</summary>
        public const int AV_HAVE_BIGENDIAN = 0;
        /// <summary>AV_HAVE_FAST_UNALIGNED = 1</summary>
        public const int AV_HAVE_FAST_UNALIGNED = 1;
        /// <summary>AV_HWACCEL_CODEC_CAP_EXPERIMENTAL = 0x0200</summary>
        public const uint AV_HWACCEL_CODEC_CAP_EXPERIMENTAL = 0x0200;
        /// <summary>AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH = (1 &lt;&lt; 1)</summary>
        public const int AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH = (1 << 1);
        /// <summary>AV_HWACCEL_FLAG_ALLOW_PROFILE_MISMATCH = (1 &lt;&lt; 2)</summary>
        public const int AV_HWACCEL_FLAG_ALLOW_PROFILE_MISMATCH = (1 << 2);
        /// <summary>AV_HWACCEL_FLAG_IGNORE_LEVEL = (1 &lt;&lt; 0)</summary>
        public const int AV_HWACCEL_FLAG_IGNORE_LEVEL = (1 << 0);
        /// <summary>AV_INPUT_BUFFER_MIN_SIZE = 16384</summary>
        public const int AV_INPUT_BUFFER_MIN_SIZE = 16384;
        /// <summary>AV_INPUT_BUFFER_PADDING_SIZE = 64</summary>
        public const int AV_INPUT_BUFFER_PADDING_SIZE = 64;
        // public static av_int_list_length = (list, term) av_int_list_length_for_size(sizeof(*(list)), list, term);
        // public static AV_IS_INPUT_DEVICE = (category) (((category) == AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT) || ((category) == AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT) || ((category) == AV_CLASS_CATEGORY_DEVICE_INPUT));
        // public static AV_IS_OUTPUT_DEVICE = (category) (((category) == AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT) || ((category) == AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT) || ((category) == AV_CLASS_CATEGORY_DEVICE_OUTPUT));
        // public static AV_JOIN = (a, b) AV_GLUE(a, b);
        // public static AV_LOG_C = (x) ((x) << 8);
        // public static av_mod_uintp2 = av_mod_uintp2_c;
        // public static AV_NE = (be, le) (le);
        // public static av_noinline = __declspec(noinline);
        // public static AV_NOPTS_VALUE = ((int64_t)(UINT64_C)0x8000000000000000);
        // public static av_noreturn = __attribute__((noreturn));
        // public static AV_NOWARN_DEPRECATED = (code) _Pragma("GCC diagnostic push") _Pragma("GCC diagnostic ignored \"-Wdeprecated-declarations\"") code _Pragma("GCC diagnostic pop");
        /// <summary>AV_NUM_DATA_POINTERS = 8</summary>
        public const int AV_NUM_DATA_POINTERS = 8;
        /// <summary>AV_OPT_ALLOW_NULL = (1 &lt;&lt; 2)</summary>
        public const int AV_OPT_ALLOW_NULL = (1 << 2);
        /// <summary>AV_OPT_MULTI_COMPONENT_RANGE = (1 &lt;&lt; 12)</summary>
        public const int AV_OPT_MULTI_COMPONENT_RANGE = (1 << 12);
        /// <summary>AV_OPT_SEARCH_CHILDREN = (1 &lt;&lt; 0)</summary>
        public const int AV_OPT_SEARCH_CHILDREN = (1 << 0);
        /// <summary>AV_OPT_SEARCH_FAKE_OBJ = (1 &lt;&lt; 1)</summary>
        public const int AV_OPT_SEARCH_FAKE_OBJ = (1 << 1);
        /// <summary>AV_OPT_SERIALIZE_OPT_FLAGS_EXACT = 0x00000002</summary>
        public const uint AV_OPT_SERIALIZE_OPT_FLAGS_EXACT = 0x00000002;
        /// <summary>AV_OPT_SERIALIZE_SKIP_DEFAULTS = 0x00000001</summary>
        public const uint AV_OPT_SERIALIZE_SKIP_DEFAULTS = 0x00000001;
        // public static av_opt_set_int_list = (obj, name, val, term, flags) (av_int_list_length(val, term) > INT_MAX / sizeof(*(val)) ? AVERROR(EINVAL) : av_opt_set_bin(obj, name, (const uint8_t *)(val), av_int_list_length(val, term) * sizeof(*(val)), flags));
        // public static av_parity = av_parity_c;
        /// <summary>AV_PARSER_PTS_NB = 4</summary>
        public const int AV_PARSER_PTS_NB = 4;
        // public static AV_PIX_FMT_0BGR32 = AV_PIX_FMT_NE(0BGR, RGB0);
        // public static AV_PIX_FMT_0RGB32 = AV_PIX_FMT_NE(0RGB, BGR0);
        // public static AV_PIX_FMT_AYUV64 = AV_PIX_FMT_NE(AYUV64BE, AYUV64LE);
        // public static AV_PIX_FMT_BAYER_BGGR16 = AV_PIX_FMT_NE(BAYER_BGGR16BE,    BAYER_BGGR16LE);
        // public static AV_PIX_FMT_BAYER_GBRG16 = AV_PIX_FMT_NE(BAYER_GBRG16BE,    BAYER_GBRG16LE);
        // public static AV_PIX_FMT_BAYER_GRBG16 = AV_PIX_FMT_NE(BAYER_GRBG16BE,    BAYER_GRBG16LE);
        // public static AV_PIX_FMT_BAYER_RGGB16 = AV_PIX_FMT_NE(BAYER_RGGB16BE,    BAYER_RGGB16LE);
        // public static AV_PIX_FMT_BGR32 = AV_PIX_FMT_NE(ABGR, RGBA);
        // public static AV_PIX_FMT_BGR32_1 = AV_PIX_FMT_NE(BGRA, ARGB);
        // public static AV_PIX_FMT_BGR444 = AV_PIX_FMT_NE(BGR444BE, BGR444LE);
        // public static AV_PIX_FMT_BGR48 = AV_PIX_FMT_NE(BGR48BE,  BGR48LE);
        // public static AV_PIX_FMT_BGR555 = AV_PIX_FMT_NE(BGR555BE, BGR555LE);
        // public static AV_PIX_FMT_BGR565 = AV_PIX_FMT_NE(BGR565BE, BGR565LE);
        // public static AV_PIX_FMT_BGRA64 = AV_PIX_FMT_NE(BGRA64BE, BGRA64LE);
        // public static AV_PIX_FMT_GBRAP10 = AV_PIX_FMT_NE(GBRAP10BE,   GBRAP10LE);
        // public static AV_PIX_FMT_GBRAP12 = AV_PIX_FMT_NE(GBRAP12BE,   GBRAP12LE);
        // public static AV_PIX_FMT_GBRAP16 = AV_PIX_FMT_NE(GBRAP16BE,   GBRAP16LE);
        // public static AV_PIX_FMT_GBRAPF32 = AV_PIX_FMT_NE(GBRAPF32BE, GBRAPF32LE);
        // public static AV_PIX_FMT_GBRP10 = AV_PIX_FMT_NE(GBRP10BE,    GBRP10LE);
        // public static AV_PIX_FMT_GBRP12 = AV_PIX_FMT_NE(GBRP12BE,    GBRP12LE);
        // public static AV_PIX_FMT_GBRP14 = AV_PIX_FMT_NE(GBRP14BE,    GBRP14LE);
        // public static AV_PIX_FMT_GBRP16 = AV_PIX_FMT_NE(GBRP16BE,    GBRP16LE);
        // public static AV_PIX_FMT_GBRP9 = AV_PIX_FMT_NE(GBRP9BE ,    GBRP9LE);
        // public static AV_PIX_FMT_GBRPF32 = AV_PIX_FMT_NE(GBRPF32BE,  GBRPF32LE);
        // public static AV_PIX_FMT_GRAY10 = AV_PIX_FMT_NE(GRAY10BE, GRAY10LE);
        // public static AV_PIX_FMT_GRAY12 = AV_PIX_FMT_NE(GRAY12BE, GRAY12LE);
        // public static AV_PIX_FMT_GRAY14 = AV_PIX_FMT_NE(GRAY14BE, GRAY14LE);
        // public static AV_PIX_FMT_GRAY16 = AV_PIX_FMT_NE(GRAY16BE, GRAY16LE);
        // public static AV_PIX_FMT_GRAY9 = AV_PIX_FMT_NE(GRAY9BE,  GRAY9LE);
        // public static AV_PIX_FMT_GRAYF32 = AV_PIX_FMT_NE(GRAYF32BE, GRAYF32LE);
        // public static AV_PIX_FMT_NE = (be, le) AV_PIX_FMT_##le;
        // public static AV_PIX_FMT_NV20 = AV_PIX_FMT_NE(NV20BE,  NV20LE);
        // public static AV_PIX_FMT_P010 = AV_PIX_FMT_NE(P010BE,  P010LE);
        // public static AV_PIX_FMT_P016 = AV_PIX_FMT_NE(P016BE,  P016LE);
        // public static AV_PIX_FMT_P210 = AV_PIX_FMT_NE(P210BE, P210LE);
        // public static AV_PIX_FMT_P216 = AV_PIX_FMT_NE(P216BE, P216LE);
        // public static AV_PIX_FMT_P410 = AV_PIX_FMT_NE(P410BE, P410LE);
        // public static AV_PIX_FMT_P416 = AV_PIX_FMT_NE(P416BE, P416LE);
        // public static AV_PIX_FMT_RGB32 = AV_PIX_FMT_NE(ARGB, BGRA);
        // public static AV_PIX_FMT_RGB32_1 = AV_PIX_FMT_NE(RGBA, ABGR);
        // public static AV_PIX_FMT_RGB444 = AV_PIX_FMT_NE(RGB444BE, RGB444LE);
        // public static AV_PIX_FMT_RGB48 = AV_PIX_FMT_NE(RGB48BE,  RGB48LE);
        // public static AV_PIX_FMT_RGB555 = AV_PIX_FMT_NE(RGB555BE, RGB555LE);
        // public static AV_PIX_FMT_RGB565 = AV_PIX_FMT_NE(RGB565BE, RGB565LE);
        // public static AV_PIX_FMT_RGBA64 = AV_PIX_FMT_NE(RGBA64BE, RGBA64LE);
        // public static AV_PIX_FMT_X2BGR10 = AV_PIX_FMT_NE(X2BGR10BE, X2BGR10LE);
        // public static AV_PIX_FMT_X2RGB10 = AV_PIX_FMT_NE(X2RGB10BE, X2RGB10LE);
        // public static AV_PIX_FMT_XYZ12 = AV_PIX_FMT_NE(XYZ12BE, XYZ12LE);
        // public static AV_PIX_FMT_Y210 = AV_PIX_FMT_NE(Y210BE,  Y210LE);
        // public static AV_PIX_FMT_YA16 = AV_PIX_FMT_NE(YA16BE,   YA16LE);
        // public static AV_PIX_FMT_YUV420P10 = AV_PIX_FMT_NE(YUV420P10BE, YUV420P10LE);
        // public static AV_PIX_FMT_YUV420P12 = AV_PIX_FMT_NE(YUV420P12BE, YUV420P12LE);
        // public static AV_PIX_FMT_YUV420P14 = AV_PIX_FMT_NE(YUV420P14BE, YUV420P14LE);
        // public static AV_PIX_FMT_YUV420P16 = AV_PIX_FMT_NE(YUV420P16BE, YUV420P16LE);
        // public static AV_PIX_FMT_YUV420P9 = AV_PIX_FMT_NE(YUV420P9BE , YUV420P9LE);
        // public static AV_PIX_FMT_YUV422P10 = AV_PIX_FMT_NE(YUV422P10BE, YUV422P10LE);
        // public static AV_PIX_FMT_YUV422P12 = AV_PIX_FMT_NE(YUV422P12BE, YUV422P12LE);
        // public static AV_PIX_FMT_YUV422P14 = AV_PIX_FMT_NE(YUV422P14BE, YUV422P14LE);
        // public static AV_PIX_FMT_YUV422P16 = AV_PIX_FMT_NE(YUV422P16BE, YUV422P16LE);
        // public static AV_PIX_FMT_YUV422P9 = AV_PIX_FMT_NE(YUV422P9BE , YUV422P9LE);
        // public static AV_PIX_FMT_YUV440P10 = AV_PIX_FMT_NE(YUV440P10BE, YUV440P10LE);
        // public static AV_PIX_FMT_YUV440P12 = AV_PIX_FMT_NE(YUV440P12BE, YUV440P12LE);
        // public static AV_PIX_FMT_YUV444P10 = AV_PIX_FMT_NE(YUV444P10BE, YUV444P10LE);
        // public static AV_PIX_FMT_YUV444P12 = AV_PIX_FMT_NE(YUV444P12BE, YUV444P12LE);
        // public static AV_PIX_FMT_YUV444P14 = AV_PIX_FMT_NE(YUV444P14BE, YUV444P14LE);
        // public static AV_PIX_FMT_YUV444P16 = AV_PIX_FMT_NE(YUV444P16BE, YUV444P16LE);
        // public static AV_PIX_FMT_YUV444P9 = AV_PIX_FMT_NE(YUV444P9BE , YUV444P9LE);
        // public static AV_PIX_FMT_YUVA420P10 = AV_PIX_FMT_NE(YUVA420P10BE, YUVA420P10LE);
        // public static AV_PIX_FMT_YUVA420P16 = AV_PIX_FMT_NE(YUVA420P16BE, YUVA420P16LE);
        // public static AV_PIX_FMT_YUVA420P9 = AV_PIX_FMT_NE(YUVA420P9BE , YUVA420P9LE);
        // public static AV_PIX_FMT_YUVA422P10 = AV_PIX_FMT_NE(YUVA422P10BE, YUVA422P10LE);
        // public static AV_PIX_FMT_YUVA422P12 = AV_PIX_FMT_NE(YUVA422P12BE, YUVA422P12LE);
        // public static AV_PIX_FMT_YUVA422P16 = AV_PIX_FMT_NE(YUVA422P16BE, YUVA422P16LE);
        // public static AV_PIX_FMT_YUVA422P9 = AV_PIX_FMT_NE(YUVA422P9BE , YUVA422P9LE);
        // public static AV_PIX_FMT_YUVA444P10 = AV_PIX_FMT_NE(YUVA444P10BE, YUVA444P10LE);
        // public static AV_PIX_FMT_YUVA444P12 = AV_PIX_FMT_NE(YUVA444P12BE, YUVA444P12LE);
        // public static AV_PIX_FMT_YUVA444P16 = AV_PIX_FMT_NE(YUVA444P16BE, YUVA444P16LE);
        // public static AV_PIX_FMT_YUVA444P9 = AV_PIX_FMT_NE(YUVA444P9BE , YUVA444P9LE);
        /// <summary>AV_PKT_DATA_QUALITY_FACTOR = AV_PKT_DATA_QUALITY_STATS</summary>
        public static readonly int AV_PKT_DATA_QUALITY_FACTOR = AVPacketSideDataType.AV_PKT_DATA_QUALITY_STATS;
        // public static av_popcount = av_popcount_c;
        // public static av_popcount64 = av_popcount64_c;
        // public static AV_PRAGMA = (s) _Pragma(#s);
        // public static av_printf_format = (fmtpos, attrpos) __attribute__((__format__(__printf__, fmtpos, attrpos)));
        /// <summary>AV_PROGRAM_RUNNING = 1</summary>
        public const int AV_PROGRAM_RUNNING = 1;
        /// <summary>AV_PTS_WRAP_ADD_OFFSET = 1</summary>
        public const int AV_PTS_WRAP_ADD_OFFSET = 1;
        /// <summary>AV_PTS_WRAP_IGNORE = 0</summary>
        public const int AV_PTS_WRAP_IGNORE = 0;
        /// <summary>AV_PTS_WRAP_SUB_OFFSET = -1</summary>
        public const int AV_PTS_WRAP_SUB_OFFSET = -1;
        // public static av_pure = __attribute__((pure));
        // public static av_sat_add32 = av_sat_add32_c;
        // public static av_sat_add64 = av_sat_add64_c;
        // public static av_sat_dadd32 = av_sat_dadd32_c;
        // public static av_sat_dsub32 = av_sat_dsub32_c;
        // public static av_sat_sub32 = av_sat_sub32_c;
        // public static av_sat_sub64 = av_sat_sub64_c;
        // public static AV_STRINGIFY = (s)         AV_TOSTRING(s);
        /// <summary>AV_SUBTITLE_FLAG_FORCED = 0x00000001</summary>
        public const uint AV_SUBTITLE_FLAG_FORCED = 0x00000001;
        /// <summary>AV_TIME_BASE = 1000000</summary>
        public const int AV_TIME_BASE = 1000000;
        // public static AV_TIME_BASE_Q = (AVRational){1, AV_TIME_BASE};
        /// <summary>AV_TIMECODE_STR_SIZE = 23</summary>
        public const int AV_TIMECODE_STR_SIZE = 23;
        // public static AV_TOSTRING = (s) #s;
        // public static av_uninit = (x) x=x;
        // public static av_unused = __attribute__((unused));
        // public static av_used = __attribute__((used));
        // public static AV_VERSION = (a, b, c) AV_VERSION_DOT(a, b, c);
        // public static AV_VERSION_DOT = (a, b, c) a ##.## b ##.## c;
        // public static AV_VERSION_INT = (a, b, c) ((a)<<16 | (b)<<8 | (c));
        // public static AV_VERSION_MAJOR = (a) ((a) >> 16);
        // public static AV_VERSION_MICRO = (a) ((a) & 0xFF);
        // public static AV_VERSION_MINOR = (a) (((a) & 0x00FF00) >> 8);
        // public static AVERROR = (e) (-(e));
        // public static AVERROR_BSF_NOT_FOUND = FFERRTAG(0xF8,'B','S','F');
        // public static AVERROR_BUFFER_TOO_SMALL = FFERRTAG( 'B','U','F','S');
        // public static AVERROR_BUG = FFERRTAG( 'B','U','G','!');
        // public static AVERROR_BUG2 = FFERRTAG( 'B','U','G',' ');
        // public static AVERROR_DECODER_NOT_FOUND = FFERRTAG(0xF8,'D','E','C');
        // public static AVERROR_DEMUXER_NOT_FOUND = FFERRTAG(0xF8,'D','E','M');
        // public static AVERROR_ENCODER_NOT_FOUND = FFERRTAG(0xF8,'E','N','C');
        // public static AVERROR_EOF = FFERRTAG( 'E','O','F',' ');
        // public static AVERROR_EXIT = FFERRTAG( 'E','X','I','T');
        /// <summary>AVERROR_EXPERIMENTAL = (-0x2bb2afa8)</summary>
        public const int AVERROR_EXPERIMENTAL = (-0x2bb2afa8);
        // public static AVERROR_EXTERNAL = FFERRTAG( 'E','X','T',' ');
        // public static AVERROR_FILTER_NOT_FOUND = FFERRTAG(0xF8,'F','I','L');
        // public static AVERROR_HTTP_BAD_REQUEST = FFERRTAG(0xF8,'4','0','0');
        // public static AVERROR_HTTP_FORBIDDEN = FFERRTAG(0xF8,'4','0','3');
        // public static AVERROR_HTTP_NOT_FOUND = FFERRTAG(0xF8,'4','0','4');
        // public static AVERROR_HTTP_OTHER_4XX = FFERRTAG(0xF8,'4','X','X');
        // public static AVERROR_HTTP_SERVER_ERROR = FFERRTAG(0xF8,'5','X','X');
        // public static AVERROR_HTTP_UNAUTHORIZED = FFERRTAG(0xF8,'4','0','1');
        /// <summary>AVERROR_INPUT_CHANGED = (-0x636e6701)</summary>
        public const int AVERROR_INPUT_CHANGED = (-0x636e6701);
        // public static AVERROR_INVALIDDATA = FFERRTAG( 'I','N','D','A');
        // public static AVERROR_MUXER_NOT_FOUND = FFERRTAG(0xF8,'M','U','X');
        // public static AVERROR_OPTION_NOT_FOUND = FFERRTAG(0xF8,'O','P','T');
        /// <summary>AVERROR_OUTPUT_CHANGED = (-0x636e6702)</summary>
        public const int AVERROR_OUTPUT_CHANGED = (-0x636e6702);
        // public static AVERROR_PATCHWELCOME = FFERRTAG( 'P','A','W','E');
        // public static AVERROR_PROTOCOL_NOT_FOUND = FFERRTAG(0xF8,'P','R','O');
        // public static AVERROR_STREAM_NOT_FOUND = FFERRTAG(0xF8,'S','T','R');
        // public static AVERROR_UNKNOWN = FFERRTAG( 'U','N','K','N');
        /// <summary>AVFILTER_CMD_FLAG_FAST = 2</summary>
        public const int AVFILTER_CMD_FLAG_FAST = 2;
        /// <summary>AVFILTER_CMD_FLAG_ONE = 1</summary>
        public const int AVFILTER_CMD_FLAG_ONE = 1;
        /// <summary>AVFILTER_FLAG_DYNAMIC_INPUTS = (1 &lt;&lt; 0)</summary>
        public const int AVFILTER_FLAG_DYNAMIC_INPUTS = (1 << 0);
        /// <summary>AVFILTER_FLAG_DYNAMIC_OUTPUTS = (1 &lt;&lt; 1)</summary>
        public const int AVFILTER_FLAG_DYNAMIC_OUTPUTS = (1 << 1);
        /// <summary>AVFILTER_FLAG_METADATA_ONLY = (1 &lt;&lt; 3)</summary>
        public const int AVFILTER_FLAG_METADATA_ONLY = (1 << 3);
        /// <summary>AVFILTER_FLAG_SLICE_THREADS = (1 &lt;&lt; 2)</summary>
        public const int AVFILTER_FLAG_SLICE_THREADS = (1 << 2);
        /// <summary>AVFILTER_FLAG_SUPPORT_TIMELINE = (AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC | AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL)</summary>
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE = (AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC | AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL);
        /// <summary>AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC = (1 &lt;&lt; 16)</summary>
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC = (1 << 16);
        /// <summary>AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL = (1 &lt;&lt; 17)</summary>
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL = (1 << 17);
        /// <summary>AVFILTER_THREAD_SLICE = (1 &lt;&lt; 0)</summary>
        public const int AVFILTER_THREAD_SLICE = (1 << 0);
        /// <summary>AVFMT_ALLOW_FLUSH = 0x10000</summary>
        public const uint AVFMT_ALLOW_FLUSH = 0x10000;
        /// <summary>AVFMT_AVOID_NEG_TS_AUTO = -1</summary>
        public const int AVFMT_AVOID_NEG_TS_AUTO = -1;
        /// <summary>AVFMT_AVOID_NEG_TS_DISABLED = 0</summary>
        public const int AVFMT_AVOID_NEG_TS_DISABLED = 0;
        /// <summary>AVFMT_AVOID_NEG_TS_MAKE_NON_NEGATIVE = 1</summary>
        public const int AVFMT_AVOID_NEG_TS_MAKE_NON_NEGATIVE = 1;
        /// <summary>AVFMT_AVOID_NEG_TS_MAKE_ZERO = 2</summary>
        public const int AVFMT_AVOID_NEG_TS_MAKE_ZERO = 2;
        /// <summary>AVFMT_EVENT_FLAG_METADATA_UPDATED = 0x0001</summary>
        public const uint AVFMT_EVENT_FLAG_METADATA_UPDATED = 0x0001;
        /// <summary>AVFMT_EXPERIMENTAL = 0x0004</summary>
        public const uint AVFMT_EXPERIMENTAL = 0x0004;
        /// <summary>AVFMT_GENERIC_INDEX = 0x0100</summary>
        public const uint AVFMT_GENERIC_INDEX = 0x0100;
        /// <summary>AVFMT_GLOBALHEADER = 0x0040</summary>
        public const uint AVFMT_GLOBALHEADER = 0x0040;
        /// <summary>AVFMT_NEEDNUMBER = 0x0002</summary>
        public const uint AVFMT_NEEDNUMBER = 0x0002;
        /// <summary>AVFMT_NO_BYTE_SEEK = 0x8000</summary>
        public const uint AVFMT_NO_BYTE_SEEK = 0x8000;
        /// <summary>AVFMT_NOBINSEARCH = 0x2000</summary>
        public const uint AVFMT_NOBINSEARCH = 0x2000;
        /// <summary>AVFMT_NODIMENSIONS = 0x0800</summary>
        public const uint AVFMT_NODIMENSIONS = 0x0800;
        /// <summary>AVFMT_NOFILE = 0x0001</summary>
        public const uint AVFMT_NOFILE = 0x0001;
        /// <summary>AVFMT_NOGENSEARCH = 0x4000</summary>
        public const uint AVFMT_NOGENSEARCH = 0x4000;
        /// <summary>AVFMT_NOSTREAMS = 0x1000</summary>
        public const uint AVFMT_NOSTREAMS = 0x1000;
        /// <summary>AVFMT_NOTIMESTAMPS = 0x0080</summary>
        public const uint AVFMT_NOTIMESTAMPS = 0x0080;
        /// <summary>AVFMT_SEEK_TO_PTS = 0x4000000</summary>
        public const uint AVFMT_SEEK_TO_PTS = 0x4000000;
        /// <summary>AVFMT_SHOW_IDS = 0x0008</summary>
        public const uint AVFMT_SHOW_IDS = 0x0008;
        /// <summary>AVFMT_TS_DISCONT = 0x0200</summary>
        public const uint AVFMT_TS_DISCONT = 0x0200;
        /// <summary>AVFMT_TS_NEGATIVE = 0x40000</summary>
        public const uint AVFMT_TS_NEGATIVE = 0x40000;
        /// <summary>AVFMT_TS_NONSTRICT = 0x20000</summary>
        public const uint AVFMT_TS_NONSTRICT = 0x20000;
        /// <summary>AVFMT_VARIABLE_FPS = 0x0400</summary>
        public const uint AVFMT_VARIABLE_FPS = 0x0400;
        /// <summary>AVFMTCTX_NOHEADER = 0x0001</summary>
        public const uint AVFMTCTX_NOHEADER = 0x0001;
        /// <summary>AVFMTCTX_UNSEEKABLE = 0x0002</summary>
        public const uint AVFMTCTX_UNSEEKABLE = 0x0002;
        /// <summary>AVINDEX_DISCARD_FRAME = 0x0002</summary>
        public const uint AVINDEX_DISCARD_FRAME = 0x0002;
        /// <summary>AVINDEX_KEYFRAME = 0x0001</summary>
        public const uint AVINDEX_KEYFRAME = 0x0001;
        // public static avio_print = (s, ...) avio_print_string_array(s, (const char*[]){__VA_ARGS__, NULL});
        /// <summary>AVIO_SEEKABLE_NORMAL = (1 &lt;&lt; 0)</summary>
        public const int AVIO_SEEKABLE_NORMAL = (1 << 0);
        /// <summary>AVIO_SEEKABLE_TIME = (1 &lt;&lt; 1)</summary>
        public const int AVIO_SEEKABLE_TIME = (1 << 1);
        /// <summary>AVPALETTE_COUNT = 256</summary>
        public const int AVPALETTE_COUNT = 256;
        /// <summary>AVPALETTE_SIZE = 1024</summary>
        public const int AVPALETTE_SIZE = 1024;
        /// <summary>AVPROBE_PADDING_SIZE = 32</summary>
        public const int AVPROBE_PADDING_SIZE = 32;
        /// <summary>AVPROBE_SCORE_EXTENSION = 50</summary>
        public const int AVPROBE_SCORE_EXTENSION = 50;
        /// <summary>AVPROBE_SCORE_MAX = 100</summary>
        public const int AVPROBE_SCORE_MAX = 100;
        /// <summary>AVPROBE_SCORE_MIME = 75</summary>
        public const int AVPROBE_SCORE_MIME = 75;
        /// <summary>AVPROBE_SCORE_RETRY = (AVPROBE_SCORE_MAX/4)</summary>
        public const int AVPROBE_SCORE_RETRY = (AVPROBE_SCORE_MAX / 4);
        /// <summary>AVPROBE_SCORE_STREAM_RETRY = (AVPROBE_SCORE_MAX/4-1)</summary>
        public const int AVPROBE_SCORE_STREAM_RETRY = (AVPROBE_SCORE_MAX / 4 - 1);
        /// <summary>AVSEEK_FORCE = 0x20000</summary>
        public const uint AVSEEK_FORCE = 0x20000;
        /// <summary>AVSEEK_SIZE = 0x10000</summary>
        public const uint AVSEEK_SIZE = 0x10000;
        /// <summary>AVSTREAM_EVENT_FLAG_METADATA_UPDATED = 0x0001</summary>
        public const uint AVSTREAM_EVENT_FLAG_METADATA_UPDATED = 0x0001;
        /// <summary>AVSTREAM_EVENT_FLAG_NEW_PACKETS = (1 &lt;&lt; 1)</summary>
        public const int AVSTREAM_EVENT_FLAG_NEW_PACKETS = (1 << 1);
        /// <summary>AVSTREAM_INIT_IN_INIT_OUTPUT = 1</summary>
        public const int AVSTREAM_INIT_IN_INIT_OUTPUT = 1;
        /// <summary>AVSTREAM_INIT_IN_WRITE_HEADER = 0</summary>
        public const int AVSTREAM_INIT_IN_WRITE_HEADER = 0;
        // public static AVUNERROR = (e) (-(e));
        // public static DECLARE_ALIGNED = (n,t,v)      t __attribute__ ((aligned (n))) v;
        // public static DECLARE_ASM_ALIGNED = (n,t,v)  t av_used __attribute__ ((aligned (n))) v;
        // public static DECLARE_ASM_CONST = (n,t,v)    static const t av_used __attribute__ ((aligned (n))) v;
        /// <summary>FF_API_AUTO_THREADS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_AUTO_THREADS = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_AV_FOPEN_UTF8 = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_AV_FOPEN_UTF8 = (LIBAVUTIL_VERSION_MAJOR < 58);
        /// <summary>FF_API_AV_MALLOCZ_ARRAY = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_AV_MALLOCZ_ARRAY = (LIBAVUTIL_VERSION_MAJOR < 58);
        /// <summary>FF_API_AVCTX_TIMEBASE = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_AVCTX_TIMEBASE = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_AVIOCONTEXT_WRITTEN = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_AVIOCONTEXT_WRITTEN = (LIBAVFORMAT_VERSION_MAJOR < 60);
        /// <summary>FF_API_AVSTREAM_CLASS = (LIBAVFORMAT_VERSION_MAJOR &gt; 59)</summary>
        public const bool FF_API_AVSTREAM_CLASS = (LIBAVFORMAT_VERSION_MAJOR > 59);
        /// <summary>FF_API_BUFFERSINK_ALLOC = (LIBAVFILTER_VERSION_MAJOR &lt; 9)</summary>
        public const bool FF_API_BUFFERSINK_ALLOC = (LIBAVFILTER_VERSION_MAJOR < 9);
        /// <summary>FF_API_COLORSPACE_NAME = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_COLORSPACE_NAME = (LIBAVUTIL_VERSION_MAJOR < 58);
        /// <summary>FF_API_COMPUTE_PKT_FIELDS2 = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_COMPUTE_PKT_FIELDS2 = (LIBAVFORMAT_VERSION_MAJOR < 60);
        /// <summary>FF_API_D2STR = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_D2STR = (LIBAVUTIL_VERSION_MAJOR < 58);
        /// <summary>FF_API_DEBUG_MV = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_DEBUG_MV = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_DECLARE_ALIGNED = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_DECLARE_ALIGNED = (LIBAVUTIL_VERSION_MAJOR < 58);
        /// <summary>FF_API_DEVICE_CAPABILITIES = (LIBAVDEVICE_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_DEVICE_CAPABILITIES = (LIBAVDEVICE_VERSION_MAJOR < 60);
        /// <summary>FF_API_FIFO_OLD_API = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_FIFO_OLD_API = (LIBAVUTIL_VERSION_MAJOR < 58);
        /// <summary>FF_API_FIFO_PEEK2 = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_FIFO_PEEK2 = (LIBAVUTIL_VERSION_MAJOR < 58);
        /// <summary>FF_API_FLAG_TRUNCATED = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_FLAG_TRUNCATED = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_GET_FRAME_CLASS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_GET_FRAME_CLASS = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_IDCT_NONE = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_IDCT_NONE = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_INIT_PACKET = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_INIT_PACKET = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_LAVF_PRIV_OPT = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_LAVF_PRIV_OPT = (LIBAVFORMAT_VERSION_MAJOR < 60);
        /// <summary>FF_API_OLD_CHANNEL_LAYOUT = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_OLD_CHANNEL_LAYOUT = (LIBAVUTIL_VERSION_MAJOR < 58);
        /// <summary>FF_API_OPENH264_CABAC = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_OPENH264_CABAC = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_OPENH264_SLICE_MODE = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_OPENH264_SLICE_MODE = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_PAD_COUNT = (LIBAVFILTER_VERSION_MAJOR &lt; 9)</summary>
        public const bool FF_API_PAD_COUNT = (LIBAVFILTER_VERSION_MAJOR < 9);
        /// <summary>FF_API_R_FRAME_RATE = 1</summary>
        public const int FF_API_R_FRAME_RATE = 1;
        /// <summary>FF_API_SUB_TEXT_FORMAT = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_SUB_TEXT_FORMAT = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_SVTAV1_OPTS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_SVTAV1_OPTS = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_SWS_PARAM_OPTION = (LIBAVFILTER_VERSION_MAJOR &lt; 9)</summary>
        public const bool FF_API_SWS_PARAM_OPTION = (LIBAVFILTER_VERSION_MAJOR < 9);
        /// <summary>FF_API_THREAD_SAFE_CALLBACKS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_THREAD_SAFE_CALLBACKS = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_UNUSED_CODEC_CAPS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_UNUSED_CODEC_CAPS = (LIBAVCODEC_VERSION_MAJOR < 60);
        /// <summary>FF_API_XVMC = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_XVMC = (LIBAVUTIL_VERSION_MAJOR < 58);
        // public static FF_ARRAY_ELEMS = (a) (sizeof(a) / sizeof((a)[0]));
        /// <summary>FF_BUG_AMV = 32</summary>
        public const int FF_BUG_AMV = 32;
        /// <summary>FF_BUG_AUTODETECT = 1</summary>
        public const int FF_BUG_AUTODETECT = 1;
        /// <summary>FF_BUG_DC_CLIP = 4096</summary>
        public const int FF_BUG_DC_CLIP = 4096;
        /// <summary>FF_BUG_DIRECT_BLOCKSIZE = 512</summary>
        public const int FF_BUG_DIRECT_BLOCKSIZE = 512;
        /// <summary>FF_BUG_EDGE = 1024</summary>
        public const int FF_BUG_EDGE = 1024;
        /// <summary>FF_BUG_HPEL_CHROMA = 2048</summary>
        public const int FF_BUG_HPEL_CHROMA = 2048;
        /// <summary>FF_BUG_IEDGE = 32768</summary>
        public const int FF_BUG_IEDGE = 32768;
        /// <summary>FF_BUG_MS = 8192</summary>
        public const int FF_BUG_MS = 8192;
        /// <summary>FF_BUG_NO_PADDING = 16</summary>
        public const int FF_BUG_NO_PADDING = 16;
        /// <summary>FF_BUG_QPEL_CHROMA = 64</summary>
        public const int FF_BUG_QPEL_CHROMA = 64;
        /// <summary>FF_BUG_QPEL_CHROMA2 = 256</summary>
        public const int FF_BUG_QPEL_CHROMA2 = 256;
        /// <summary>FF_BUG_STD_QPEL = 128</summary>
        public const int FF_BUG_STD_QPEL = 128;
        /// <summary>FF_BUG_TRUNCATED = 16384</summary>
        public const int FF_BUG_TRUNCATED = 16384;
        /// <summary>FF_BUG_UMP4 = 8</summary>
        public const int FF_BUG_UMP4 = 8;
        /// <summary>FF_BUG_XVID_ILACE = 4</summary>
        public const int FF_BUG_XVID_ILACE = 4;
        // public static FF_CEIL_RSHIFT = AV_CEIL_RSHIFT;
        /// <summary>FF_CODEC_PROPERTY_CLOSED_CAPTIONS = 0x00000002</summary>
        public const uint FF_CODEC_PROPERTY_CLOSED_CAPTIONS = 0x00000002;
        /// <summary>FF_CODEC_PROPERTY_FILM_GRAIN = 0x00000004</summary>
        public const uint FF_CODEC_PROPERTY_FILM_GRAIN = 0x00000004;
        /// <summary>FF_CODEC_PROPERTY_LOSSLESS = 0x00000001</summary>
        public const uint FF_CODEC_PROPERTY_LOSSLESS = 0x00000001;
        /// <summary>FF_COMPLIANCE_EXPERIMENTAL = -2</summary>
        public const int FF_COMPLIANCE_EXPERIMENTAL = -2;
        /// <summary>FF_COMPLIANCE_NORMAL = 0</summary>
        public const int FF_COMPLIANCE_NORMAL = 0;
        /// <summary>FF_COMPLIANCE_STRICT = 1</summary>
        public const int FF_COMPLIANCE_STRICT = 1;
        /// <summary>FF_COMPLIANCE_UNOFFICIAL = -1</summary>
        public const int FF_COMPLIANCE_UNOFFICIAL = -1;
        /// <summary>FF_COMPLIANCE_VERY_STRICT = 2</summary>
        public const int FF_COMPLIANCE_VERY_STRICT = 2;
        /// <summary>FF_COMPRESSION_DEFAULT = -1</summary>
        public const int FF_COMPRESSION_DEFAULT = -1;
        /// <summary>FF_DCT_ALTIVEC = 5</summary>
        public const int FF_DCT_ALTIVEC = 5;
        /// <summary>FF_DCT_AUTO = 0</summary>
        public const int FF_DCT_AUTO = 0;
        /// <summary>FF_DCT_FAAN = 6</summary>
        public const int FF_DCT_FAAN = 6;
        /// <summary>FF_DCT_FASTINT = 1</summary>
        public const int FF_DCT_FASTINT = 1;
        /// <summary>FF_DCT_INT = 2</summary>
        public const int FF_DCT_INT = 2;
        /// <summary>FF_DCT_MMX = 3</summary>
        public const int FF_DCT_MMX = 3;
        /// <summary>FF_DEBUG_BITSTREAM = 4</summary>
        public const int FF_DEBUG_BITSTREAM = 4;
        /// <summary>FF_DEBUG_BUFFERS = 0x00008000</summary>
        public const uint FF_DEBUG_BUFFERS = 0x00008000;
        /// <summary>FF_DEBUG_BUGS = 0x00001000</summary>
        public const uint FF_DEBUG_BUGS = 0x00001000;
        /// <summary>FF_DEBUG_DCT_COEFF = 0x00000040</summary>
        public const uint FF_DEBUG_DCT_COEFF = 0x00000040;
        /// <summary>FF_DEBUG_ER = 0x00000400</summary>
        public const uint FF_DEBUG_ER = 0x00000400;
        /// <summary>FF_DEBUG_GREEN_MD = 0x00800000</summary>
        public const uint FF_DEBUG_GREEN_MD = 0x00800000;
        /// <summary>FF_DEBUG_MB_TYPE = 8</summary>
        public const int FF_DEBUG_MB_TYPE = 8;
        /// <summary>FF_DEBUG_MMCO = 0x00000800</summary>
        public const uint FF_DEBUG_MMCO = 0x00000800;
        /// <summary>FF_DEBUG_NOMC = 0x01000000</summary>
        public const uint FF_DEBUG_NOMC = 0x01000000;
        /// <summary>FF_DEBUG_PICT_INFO = 1</summary>
        public const int FF_DEBUG_PICT_INFO = 1;
        /// <summary>FF_DEBUG_QP = 16</summary>
        public const int FF_DEBUG_QP = 16;
        /// <summary>FF_DEBUG_RC = 2</summary>
        public const int FF_DEBUG_RC = 2;
        /// <summary>FF_DEBUG_SKIP = 0x00000080</summary>
        public const uint FF_DEBUG_SKIP = 0x00000080;
        /// <summary>FF_DEBUG_STARTCODE = 0x00000100</summary>
        public const uint FF_DEBUG_STARTCODE = 0x00000100;
        /// <summary>FF_DEBUG_THREADS = 0x00010000</summary>
        public const uint FF_DEBUG_THREADS = 0x00010000;
        /// <summary>FF_DEBUG_VIS_MV_B_BACK = 0x00000004</summary>
        public const uint FF_DEBUG_VIS_MV_B_BACK = 0x00000004;
        /// <summary>FF_DEBUG_VIS_MV_B_FOR = 0x00000002</summary>
        public const uint FF_DEBUG_VIS_MV_B_FOR = 0x00000002;
        /// <summary>FF_DEBUG_VIS_MV_P_FOR = 0x00000001</summary>
        public const uint FF_DEBUG_VIS_MV_P_FOR = 0x00000001;
        /// <summary>FF_DECODE_ERROR_CONCEALMENT_ACTIVE = 4</summary>
        public const int FF_DECODE_ERROR_CONCEALMENT_ACTIVE = 4;
        /// <summary>FF_DECODE_ERROR_DECODE_SLICES = 8</summary>
        public const int FF_DECODE_ERROR_DECODE_SLICES = 8;
        /// <summary>FF_DECODE_ERROR_INVALID_BITSTREAM = 1</summary>
        public const int FF_DECODE_ERROR_INVALID_BITSTREAM = 1;
        /// <summary>FF_DECODE_ERROR_MISSING_REFERENCE = 2</summary>
        public const int FF_DECODE_ERROR_MISSING_REFERENCE = 2;
        /// <summary>FF_DXVA2_WORKAROUND_INTEL_CLEARVIDEO = 2</summary>
        public const int FF_DXVA2_WORKAROUND_INTEL_CLEARVIDEO = 2;
        /// <summary>FF_DXVA2_WORKAROUND_SCALING_LIST_ZIGZAG = 1</summary>
        public const int FF_DXVA2_WORKAROUND_SCALING_LIST_ZIGZAG = 1;
        /// <summary>FF_EC_DEBLOCK = 2</summary>
        public const int FF_EC_DEBLOCK = 2;
        /// <summary>FF_EC_FAVOR_INTER = 256</summary>
        public const int FF_EC_FAVOR_INTER = 256;
        /// <summary>FF_EC_GUESS_MVS = 1</summary>
        public const int FF_EC_GUESS_MVS = 1;
        /// <summary>FF_FDEBUG_TS = 0x0001</summary>
        public const uint FF_FDEBUG_TS = 0x0001;
        /// <summary>FF_HLS_TS_OPTIONS = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_HLS_TS_OPTIONS = (LIBAVFORMAT_VERSION_MAJOR < 60);
        /// <summary>FF_IDCT_ALTIVEC = 8</summary>
        public const int FF_IDCT_ALTIVEC = 8;
        /// <summary>FF_IDCT_ARM = 7</summary>
        public const int FF_IDCT_ARM = 7;
        /// <summary>FF_IDCT_AUTO = 0</summary>
        public const int FF_IDCT_AUTO = 0;
        /// <summary>FF_IDCT_FAAN = 20</summary>
        public const int FF_IDCT_FAAN = 20;
        /// <summary>FF_IDCT_INT = 1</summary>
        public const int FF_IDCT_INT = 1;
        /// <summary>FF_IDCT_NONE = 24</summary>
        public const int FF_IDCT_NONE = 24;
        /// <summary>FF_IDCT_SIMPLE = 2</summary>
        public const int FF_IDCT_SIMPLE = 2;
        /// <summary>FF_IDCT_SIMPLEARM = 10</summary>
        public const int FF_IDCT_SIMPLEARM = 10;
        /// <summary>FF_IDCT_SIMPLEARMV5TE = 16</summary>
        public const int FF_IDCT_SIMPLEARMV5TE = 16;
        /// <summary>FF_IDCT_SIMPLEARMV6 = 17</summary>
        public const int FF_IDCT_SIMPLEARMV6 = 17;
        /// <summary>FF_IDCT_SIMPLEAUTO = 128</summary>
        public const int FF_IDCT_SIMPLEAUTO = 128;
        /// <summary>FF_IDCT_SIMPLEMMX = 3</summary>
        public const int FF_IDCT_SIMPLEMMX = 3;
        /// <summary>FF_IDCT_SIMPLENEON = 22</summary>
        public const int FF_IDCT_SIMPLENEON = 22;
        /// <summary>FF_IDCT_XVID = 14</summary>
        public const int FF_IDCT_XVID = 14;
        /// <summary>FF_LAMBDA_MAX = (256*128-1)</summary>
        public const int FF_LAMBDA_MAX = (256 * 128 - 1);
        /// <summary>FF_LAMBDA_SCALE = (1&lt;&lt;FF_LAMBDA_SHIFT)</summary>
        public const int FF_LAMBDA_SCALE = (1 << FF_LAMBDA_SHIFT);
        /// <summary>FF_LAMBDA_SHIFT = 7</summary>
        public const int FF_LAMBDA_SHIFT = 7;
        /// <summary>FF_LEVEL_UNKNOWN = -99</summary>
        public const int FF_LEVEL_UNKNOWN = -99;
        /// <summary>FF_LOSS_ALPHA = 0x0008</summary>
        public const uint FF_LOSS_ALPHA = 0x0008;
        /// <summary>FF_LOSS_CHROMA = 0x0020</summary>
        public const uint FF_LOSS_CHROMA = 0x0020;
        /// <summary>FF_LOSS_COLORQUANT = 0x0010</summary>
        public const uint FF_LOSS_COLORQUANT = 0x0010;
        /// <summary>FF_LOSS_COLORSPACE = 0x0004</summary>
        public const uint FF_LOSS_COLORSPACE = 0x0004;
        /// <summary>FF_LOSS_DEPTH = 0x0002</summary>
        public const uint FF_LOSS_DEPTH = 0x0002;
        /// <summary>FF_LOSS_RESOLUTION = 0x0001</summary>
        public const uint FF_LOSS_RESOLUTION = 0x0001;
        /// <summary>FF_QP2LAMBDA = 118</summary>
        public const int FF_QP2LAMBDA = 118;
        /// <summary>FF_QUALITY_SCALE = FF_LAMBDA_SCALE</summary>
        public const int FF_QUALITY_SCALE = FF_LAMBDA_SCALE;
        /// <summary>FF_SUB_CHARENC_MODE_AUTOMATIC = 0</summary>
        public const int FF_SUB_CHARENC_MODE_AUTOMATIC = 0;
        /// <summary>FF_SUB_CHARENC_MODE_DO_NOTHING = -1</summary>
        public const int FF_SUB_CHARENC_MODE_DO_NOTHING = -1;
        /// <summary>FF_SUB_CHARENC_MODE_IGNORE = 2</summary>
        public const int FF_SUB_CHARENC_MODE_IGNORE = 2;
        /// <summary>FF_SUB_CHARENC_MODE_PRE_DECODER = 1</summary>
        public const int FF_SUB_CHARENC_MODE_PRE_DECODER = 1;
        /// <summary>FF_SUB_TEXT_FMT_ASS = 0</summary>
        public const int FF_SUB_TEXT_FMT_ASS = 0;
        /// <summary>FF_THREAD_FRAME = 1</summary>
        public const int FF_THREAD_FRAME = 1;
        /// <summary>FF_THREAD_SLICE = 2</summary>
        public const int FF_THREAD_SLICE = 2;
        // public static FFABS = (a) ((a) >= 0 ? (a) : (-(a)));
        // public static FFABS64U = (a) ((a) <= 0 ? -(uint64_t)(a) : (uint64_t)(a));
        // public static FFABSU = (a) ((a) <= 0 ? -(unsigned)(a) : (unsigned)(a));
        // public static FFALIGN = (x, a) (((x)+(a)-1)&~((a)-1));
        // public static FFDIFFSIGN = (x,y) (((x)>(y)) - ((x)<(y)));
        // public static FFERRTAG = (a, b, c, d) (-(int)MKTAG(a, b, c, d));
        // public static FFMAX = (a,b) ((a) > (b) ? (a) : (b));
        // public static FFMAX3 = (a,b,c) FFMAX(FFMAX(a,b),c);
        // public static FFMIN = (a,b) ((a) > (b) ? (b) : (a));
        // public static FFMIN3 = (a,b,c) FFMIN(FFMIN(a,b),c);
        // public static FFNABS = (a) ((a) <= 0 ? (a) : (-(a)));
        // public static FFSIGN = (a) ((a) > 0 ? 1 : -1);
        // public static FFSWAP = (type,a,b) do{type SWAP_tmp= b; b= a; a= SWAP_tmp;}while(0);
        // public static FFUDIV = (a,b) (((a)>0 ?(a):(a)-(b)+1) / (b));
        // public static FFUMOD = (a,b) ((a)-(b)*FFUDIV(a,b));
        // public static GET_UTF16 = (val, GET_16BIT, ERROR)val = (GET_16BIT);{unsigned int hi = val - 0xD800;if (hi < 0x800) {val = (GET_16BIT) - 0xDC00;if (val > 0x3FFU || hi > 0x3FFU){ERROR}val += (hi<<10) + 0x10000;}};
        // public static GET_UTF8 = (val, GET_BYTE, ERROR)val= (GET_BYTE);{uint32_t top = (val & 128) >> 1;if ((val & 0xc0) == 0x80 || val >= 0xFE){ERROR}while (val & top) {unsigned int tmp = (GET_BYTE) - 128;if(tmp>>6){ERROR}val= (val<<6) + tmp;top <<= 5;}val &= (top << 1) - 1;};
        // public static LIBAVCODEC_BUILD = LIBAVCODEC_VERSION_INT;
        /// <summary>LIBAVCODEC_IDENT = &quot;Lavc&quot; AV_STRINGIFY(LIBAVCODEC_VERSION)</summary>
        public static readonly string LIBAVCODEC_IDENT = "Lavc" + AV_STRINGIFY(LIBAVCODEC_VERSION);
        // public static LIBAVCODEC_VERSION = AV_VERSION(LIBAVCODEC_VERSION_MAJOR,    LIBAVCODEC_VERSION_MINOR,    LIBAVCODEC_VERSION_MICRO);
        // public static LIBAVCODEC_VERSION_INT = AV_VERSION_INT(LIBAVCODEC_VERSION_MAJOR, LIBAVCODEC_VERSION_MINOR, LIBAVCODEC_VERSION_MICRO);
        /// <summary>LIBAVCODEC_VERSION_MAJOR = 59</summary>
        public const int LIBAVCODEC_VERSION_MAJOR = 59;
        /// <summary>LIBAVCODEC_VERSION_MICRO = 100</summary>
        public const int LIBAVCODEC_VERSION_MICRO = 100;
        /// <summary>LIBAVCODEC_VERSION_MINOR = 37</summary>
        public const int LIBAVCODEC_VERSION_MINOR = 37;
        // public static LIBAVDEVICE_BUILD = LIBAVDEVICE_VERSION_INT;
        /// <summary>LIBAVDEVICE_IDENT = &quot;Lavd&quot; AV_STRINGIFY(LIBAVDEVICE_VERSION)</summary>
        public static readonly string LIBAVDEVICE_IDENT = "Lavd" + AV_STRINGIFY(LIBAVDEVICE_VERSION);
        // public static LIBAVDEVICE_VERSION = AV_VERSION(LIBAVDEVICE_VERSION_MAJOR, LIBAVDEVICE_VERSION_MINOR, LIBAVDEVICE_VERSION_MICRO);
        // public static LIBAVDEVICE_VERSION_INT = AV_VERSION_INT(LIBAVDEVICE_VERSION_MAJOR, LIBAVDEVICE_VERSION_MINOR, LIBAVDEVICE_VERSION_MICRO);
        /// <summary>LIBAVDEVICE_VERSION_MAJOR = 59</summary>
        public const int LIBAVDEVICE_VERSION_MAJOR = 59;
        /// <summary>LIBAVDEVICE_VERSION_MICRO = 100</summary>
        public const int LIBAVDEVICE_VERSION_MICRO = 100;
        /// <summary>LIBAVDEVICE_VERSION_MINOR = 7</summary>
        public const int LIBAVDEVICE_VERSION_MINOR = 7;
        // public static LIBAVFILTER_BUILD = LIBAVFILTER_VERSION_INT;
        /// <summary>LIBAVFILTER_IDENT = &quot;Lavfi&quot; AV_STRINGIFY(LIBAVFILTER_VERSION)</summary>
        public static readonly string LIBAVFILTER_IDENT = "Lavfi" + AV_STRINGIFY(LIBAVFILTER_VERSION);
        // public static LIBAVFILTER_VERSION = AV_VERSION(LIBAVFILTER_VERSION_MAJOR,   LIBAVFILTER_VERSION_MINOR,   LIBAVFILTER_VERSION_MICRO);
        // public static LIBAVFILTER_VERSION_INT = AV_VERSION_INT(LIBAVFILTER_VERSION_MAJOR, LIBAVFILTER_VERSION_MINOR, LIBAVFILTER_VERSION_MICRO);
        /// <summary>LIBAVFILTER_VERSION_MAJOR = 8</summary>
        public const int LIBAVFILTER_VERSION_MAJOR = 8;
        /// <summary>LIBAVFILTER_VERSION_MICRO = 100</summary>
        public const int LIBAVFILTER_VERSION_MICRO = 100;
        /// <summary>LIBAVFILTER_VERSION_MINOR = 44</summary>
        public const int LIBAVFILTER_VERSION_MINOR = 44;
        // public static LIBAVFORMAT_BUILD = LIBAVFORMAT_VERSION_INT;
        /// <summary>LIBAVFORMAT_IDENT = &quot;Lavf&quot; AV_STRINGIFY(LIBAVFORMAT_VERSION)</summary>
        public static readonly string LIBAVFORMAT_IDENT = "Lavf" + AV_STRINGIFY(LIBAVFORMAT_VERSION);
        // public static LIBAVFORMAT_VERSION = AV_VERSION(LIBAVFORMAT_VERSION_MAJOR,   LIBAVFORMAT_VERSION_MINOR,   LIBAVFORMAT_VERSION_MICRO);
        // public static LIBAVFORMAT_VERSION_INT = AV_VERSION_INT(LIBAVFORMAT_VERSION_MAJOR, LIBAVFORMAT_VERSION_MINOR, LIBAVFORMAT_VERSION_MICRO);
        /// <summary>LIBAVFORMAT_VERSION_MAJOR = 59</summary>
        public const int LIBAVFORMAT_VERSION_MAJOR = 59;
        /// <summary>LIBAVFORMAT_VERSION_MICRO = 100</summary>
        public const int LIBAVFORMAT_VERSION_MICRO = 100;
        /// <summary>LIBAVFORMAT_VERSION_MINOR = 27</summary>
        public const int LIBAVFORMAT_VERSION_MINOR = 27;
        // public static LIBAVUTIL_BUILD = LIBAVUTIL_VERSION_INT;
        /// <summary>LIBAVUTIL_IDENT = &quot;Lavu&quot; AV_STRINGIFY(LIBAVUTIL_VERSION)</summary>
        public static readonly string LIBAVUTIL_IDENT = "Lavu" + AV_STRINGIFY(LIBAVUTIL_VERSION);
        // public static LIBAVUTIL_VERSION = AV_VERSION(LIBAVUTIL_VERSION_MAJOR,     LIBAVUTIL_VERSION_MINOR,     LIBAVUTIL_VERSION_MICRO);
        // public static LIBAVUTIL_VERSION_INT = AV_VERSION_INT(LIBAVUTIL_VERSION_MAJOR, LIBAVUTIL_VERSION_MINOR, LIBAVUTIL_VERSION_MICRO);
        /// <summary>LIBAVUTIL_VERSION_MAJOR = 57</summary>
        public const int LIBAVUTIL_VERSION_MAJOR = 57;
        /// <summary>LIBAVUTIL_VERSION_MICRO = 100</summary>
        public const int LIBAVUTIL_VERSION_MICRO = 100;
        /// <summary>LIBAVUTIL_VERSION_MINOR = 28</summary>
        public const int LIBAVUTIL_VERSION_MINOR = 28;
        // public static LIBPOSTPROC_BUILD = LIBPOSTPROC_VERSION_INT;
        /// <summary>LIBPOSTPROC_IDENT = &quot;postproc&quot; AV_STRINGIFY(LIBPOSTPROC_VERSION)</summary>
        public static readonly string LIBPOSTPROC_IDENT = "postproc" + AV_STRINGIFY(LIBPOSTPROC_VERSION);
        // public static LIBPOSTPROC_VERSION = AV_VERSION(LIBPOSTPROC_VERSION_MAJOR, LIBPOSTPROC_VERSION_MINOR, LIBPOSTPROC_VERSION_MICRO);
        // public static LIBPOSTPROC_VERSION_INT = AV_VERSION_INT(LIBPOSTPROC_VERSION_MAJOR, LIBPOSTPROC_VERSION_MINOR, LIBPOSTPROC_VERSION_MICRO);
        /// <summary>LIBPOSTPROC_VERSION_MAJOR = 56</summary>
        public const int LIBPOSTPROC_VERSION_MAJOR = 56;
        /// <summary>LIBPOSTPROC_VERSION_MICRO = 100</summary>
        public const int LIBPOSTPROC_VERSION_MICRO = 100;
        /// <summary>LIBPOSTPROC_VERSION_MINOR = 6</summary>
        public const int LIBPOSTPROC_VERSION_MINOR = 6;
        // public static LIBSWRESAMPLE_BUILD = LIBSWRESAMPLE_VERSION_INT;
        /// <summary>LIBSWRESAMPLE_IDENT = &quot;SwR&quot; AV_STRINGIFY(LIBSWRESAMPLE_VERSION)</summary>
        public static readonly string LIBSWRESAMPLE_IDENT = "SwR" + AV_STRINGIFY(LIBSWRESAMPLE_VERSION);
        // public static LIBSWRESAMPLE_VERSION = AV_VERSION(LIBSWRESAMPLE_VERSION_MAJOR, LIBSWRESAMPLE_VERSION_MINOR, LIBSWRESAMPLE_VERSION_MICRO);
        // public static LIBSWRESAMPLE_VERSION_INT = AV_VERSION_INT(LIBSWRESAMPLE_VERSION_MAJOR, LIBSWRESAMPLE_VERSION_MINOR, LIBSWRESAMPLE_VERSION_MICRO);
        /// <summary>LIBSWRESAMPLE_VERSION_MAJOR = 4</summary>
        public const int LIBSWRESAMPLE_VERSION_MAJOR = 4;
        /// <summary>LIBSWRESAMPLE_VERSION_MICRO = 100</summary>
        public const int LIBSWRESAMPLE_VERSION_MICRO = 100;
        /// <summary>LIBSWRESAMPLE_VERSION_MINOR = 7</summary>
        public const int LIBSWRESAMPLE_VERSION_MINOR = 7;
        // public static LIBSWSCALE_BUILD = LIBSWSCALE_VERSION_INT;
        /// <summary>LIBSWSCALE_IDENT = &quot;SwS&quot; AV_STRINGIFY(LIBSWSCALE_VERSION)</summary>
        public static readonly string LIBSWSCALE_IDENT = "SwS" + AV_STRINGIFY(LIBSWSCALE_VERSION);
        // public static LIBSWSCALE_VERSION = AV_VERSION(LIBSWSCALE_VERSION_MAJOR, LIBSWSCALE_VERSION_MINOR, LIBSWSCALE_VERSION_MICRO);
        // public static LIBSWSCALE_VERSION_INT = AV_VERSION_INT(LIBSWSCALE_VERSION_MAJOR, LIBSWSCALE_VERSION_MINOR, LIBSWSCALE_VERSION_MICRO);
        /// <summary>LIBSWSCALE_VERSION_MAJOR = 6</summary>
        public const int LIBSWSCALE_VERSION_MAJOR = 6;
        /// <summary>LIBSWSCALE_VERSION_MICRO = 100</summary>
        public const int LIBSWSCALE_VERSION_MICRO = 100;
        /// <summary>LIBSWSCALE_VERSION_MINOR = 7</summary>
        public const int LIBSWSCALE_VERSION_MINOR = 7;
        /// <summary>M_E = 2.7182818284590452354</summary>
        public const double M_E = 2.7182818284590452354;
        /// <summary>M_LN10 = 2.30258509299404568402</summary>
        public const double M_LN10 = 2.30258509299404568402;
        /// <summary>M_LN2 = 0.69314718055994530942</summary>
        public const double M_LN2 = 0.69314718055994530942;
        /// <summary>M_LOG2_10 = 3.32192809488736234787</summary>
        public const double M_LOG2_10 = 3.32192809488736234787;
        /// <summary>M_PHI = 1.61803398874989484820</summary>
        public const double M_PHI = 1.61803398874989484820;
        /// <summary>M_PI = 3.14159265358979323846</summary>
        public const double M_PI = 3.14159265358979323846;
        /// <summary>M_PI_2 = 1.57079632679489661923</summary>
        public const double M_PI_2 = 1.57079632679489661923;
        /// <summary>M_SQRT1_2 = 0.70710678118654752440</summary>
        public const double M_SQRT1_2 = 0.70710678118654752440;
        /// <summary>M_SQRT2 = 1.41421356237309504880</summary>
        public const double M_SQRT2 = 1.41421356237309504880;
        // public static MKBETAG = (a,b,c,d) ((d) | ((c) << 8) | ((b) << 16) | ((unsigned)(a) << 24));
        // public static MKTAG = (a,b,c,d)   ((a) | ((b) << 8) | ((c) << 16) | ((unsigned)(d) << 24));
        /// <summary>PP_CPU_CAPS_3DNOW = 0x40000000</summary>
        public const uint PP_CPU_CAPS_3DNOW = 0x40000000;
        /// <summary>PP_CPU_CAPS_ALTIVEC = 0x10000000</summary>
        public const uint PP_CPU_CAPS_ALTIVEC = 0x10000000;
        /// <summary>PP_CPU_CAPS_AUTO = 0x00080000</summary>
        public const uint PP_CPU_CAPS_AUTO = 0x00080000;
        /// <summary>PP_CPU_CAPS_MMX = 0x80000000</summary>
        public const uint PP_CPU_CAPS_MMX = 0x80000000;
        /// <summary>PP_CPU_CAPS_MMX2 = 0x20000000</summary>
        public const uint PP_CPU_CAPS_MMX2 = 0x20000000;
        /// <summary>PP_FORMAT = 0x00000008</summary>
        public const uint PP_FORMAT = 0x00000008;
        /// <summary>PP_FORMAT_411 = (0x00000002|PP_FORMAT)</summary>
        public const uint PP_FORMAT_411 = (0x00000002 | PP_FORMAT);
        /// <summary>PP_FORMAT_420 = (0x00000011|PP_FORMAT)</summary>
        public const uint PP_FORMAT_420 = (0x00000011 | PP_FORMAT);
        /// <summary>PP_FORMAT_422 = (0x00000001|PP_FORMAT)</summary>
        public const uint PP_FORMAT_422 = (0x00000001 | PP_FORMAT);
        /// <summary>PP_FORMAT_440 = (0x00000010|PP_FORMAT)</summary>
        public const uint PP_FORMAT_440 = (0x00000010 | PP_FORMAT);
        /// <summary>PP_FORMAT_444 = (0x00000000|PP_FORMAT)</summary>
        public const uint PP_FORMAT_444 = (0x00000000 | PP_FORMAT);
        /// <summary>PP_PICT_TYPE_QP2 = 0x00000010</summary>
        public const uint PP_PICT_TYPE_QP2 = 0x00000010;
        /// <summary>PP_QUALITY_MAX = 6</summary>
        public const int PP_QUALITY_MAX = 6;
        // public static PUT_UTF16 = (val, tmp, PUT_16BIT){uint32_t in = val;if (in < 0x10000) {tmp = in;PUT_16BIT} else {tmp = 0xD800 | ((in - 0x10000) >> 10);PUT_16BITtmp = 0xDC00 | ((in - 0x10000) & 0x3FF);PUT_16BIT}};
        // public static PUT_UTF8 = (val, tmp, PUT_BYTE){int bytes, shift;uint32_t in = val;if (in < 0x80) {tmp = in;PUT_BYTE} else {bytes = (av_log2(in) + 4) / 5;shift = (bytes - 1) * 6;tmp = (256 - (256 >> bytes)) | (in >> shift);PUT_BYTEwhile (shift >= 6) {shift -= 6;tmp = 0x80 | ((in >> shift) & 0x3f);PUT_BYTE}}};
        // public static ROUNDED_DIV = (a,b) (((a)>=0 ? (a) + ((b)>>1) : (a) - ((b)>>1))/(b));
        // public static RSHIFT = (a,b) ((a) > 0 ? ((a) + ((1<<(b))>>1))>>(b) : ((a) + ((1<<(b))>>1)-1)>>(b));
        /// <summary>SWR_FLAG_RESAMPLE = 1</summary>
        public const int SWR_FLAG_RESAMPLE = 1;
        /// <summary>SWS_ACCURATE_RND = 0x40000</summary>
        public const uint SWS_ACCURATE_RND = 0x40000;
        /// <summary>SWS_AREA = 0x20</summary>
        public const uint SWS_AREA = 0x20;
        /// <summary>SWS_BICUBIC = 4</summary>
        public const int SWS_BICUBIC = 4;
        /// <summary>SWS_BICUBLIN = 0x40</summary>
        public const uint SWS_BICUBLIN = 0x40;
        /// <summary>SWS_BILINEAR = 2</summary>
        public const int SWS_BILINEAR = 2;
        /// <summary>SWS_BITEXACT = 0x80000</summary>
        public const uint SWS_BITEXACT = 0x80000;
        /// <summary>SWS_CS_BT2020 = 9</summary>
        public const int SWS_CS_BT2020 = 9;
        /// <summary>SWS_CS_DEFAULT = 5</summary>
        public const int SWS_CS_DEFAULT = 5;
        /// <summary>SWS_CS_FCC = 4</summary>
        public const int SWS_CS_FCC = 4;
        /// <summary>SWS_CS_ITU601 = 5</summary>
        public const int SWS_CS_ITU601 = 5;
        /// <summary>SWS_CS_ITU624 = 5</summary>
        public const int SWS_CS_ITU624 = 5;
        /// <summary>SWS_CS_ITU709 = 1</summary>
        public const int SWS_CS_ITU709 = 1;
        /// <summary>SWS_CS_SMPTE170M = 5</summary>
        public const int SWS_CS_SMPTE170M = 5;
        /// <summary>SWS_CS_SMPTE240M = 7</summary>
        public const int SWS_CS_SMPTE240M = 7;
        /// <summary>SWS_DIRECT_BGR = 0x8000</summary>
        public const uint SWS_DIRECT_BGR = 0x8000;
        /// <summary>SWS_ERROR_DIFFUSION = 0x800000</summary>
        public const uint SWS_ERROR_DIFFUSION = 0x800000;
        /// <summary>SWS_FAST_BILINEAR = 1</summary>
        public const int SWS_FAST_BILINEAR = 1;
        /// <summary>SWS_FULL_CHR_H_INP = 0x4000</summary>
        public const uint SWS_FULL_CHR_H_INP = 0x4000;
        /// <summary>SWS_FULL_CHR_H_INT = 0x2000</summary>
        public const uint SWS_FULL_CHR_H_INT = 0x2000;
        /// <summary>SWS_GAUSS = 0x80</summary>
        public const uint SWS_GAUSS = 0x80;
        /// <summary>SWS_LANCZOS = 0x200</summary>
        public const uint SWS_LANCZOS = 0x200;
        /// <summary>SWS_MAX_REDUCE_CUTOFF = 0.002</summary>
        public const double SWS_MAX_REDUCE_CUTOFF = 0.002;
        /// <summary>SWS_PARAM_DEFAULT = 123456</summary>
        public const int SWS_PARAM_DEFAULT = 123456;
        /// <summary>SWS_POINT = 0x10</summary>
        public const uint SWS_POINT = 0x10;
        /// <summary>SWS_PRINT_INFO = 0x1000</summary>
        public const uint SWS_PRINT_INFO = 0x1000;
        /// <summary>SWS_SINC = 0x100</summary>
        public const uint SWS_SINC = 0x100;
        /// <summary>SWS_SPLINE = 0x400</summary>
        public const uint SWS_SPLINE = 0x400;
        /// <summary>SWS_SRC_V_CHR_DROP_MASK = 0x30000</summary>
        public const uint SWS_SRC_V_CHR_DROP_MASK = 0x30000;
        /// <summary>SWS_SRC_V_CHR_DROP_SHIFT = 16</summary>
        public const int SWS_SRC_V_CHR_DROP_SHIFT = 16;
        /// <summary>SWS_X = 8</summary>
        public const int SWS_X = 8;
        /// <summary>Macro enum, prefix: AV_CH_</summary>
        [Flags]
        public enum Channels : ulong
        {
            /// <summary>AV_CH_BACK_CENTER = (1ULL &lt;&lt; AV_CHAN_BACK_CENTER          )</summary>
            BackCenter = (1 << AV_CHAN_BACK_CENTER),
            
            /// <summary>AV_CH_BACK_LEFT = (1ULL &lt;&lt; AV_CHAN_BACK_LEFT            )</summary>
            BackLeft = (1 << AV_CHAN_BACK_LEFT),
            
            /// <summary>AV_CH_BACK_RIGHT = (1ULL &lt;&lt; AV_CHAN_BACK_RIGHT           )</summary>
            BackRight = (1 << AV_CHAN_BACK_RIGHT),
            
            /// <summary>AV_CH_BOTTOM_FRONT_CENTER = (1ULL &lt;&lt; AV_CHAN_BOTTOM_FRONT_CENTER  )</summary>
            BottomFrontCenter = (1 << AV_CHAN_BOTTOM_FRONT_CENTER),
            
            /// <summary>AV_CH_BOTTOM_FRONT_LEFT = (1ULL &lt;&lt; AV_CHAN_BOTTOM_FRONT_LEFT    )</summary>
            BottomFrontLeft = (1 << AV_CHAN_BOTTOM_FRONT_LEFT),
            
            /// <summary>AV_CH_BOTTOM_FRONT_RIGHT = (1ULL &lt;&lt; AV_CHAN_BOTTOM_FRONT_RIGHT   )</summary>
            BottomFrontRight = (1 << AV_CHAN_BOTTOM_FRONT_RIGHT),
            
            /// <summary>AV_CH_FRONT_CENTER = (1ULL &lt;&lt; AV_CHAN_FRONT_CENTER         )</summary>
            FrontCenter = (1 << AV_CHAN_FRONT_CENTER),
            
            /// <summary>AV_CH_FRONT_LEFT = (1ULL &lt;&lt; AV_CHAN_FRONT_LEFT           )</summary>
            FrontLeft = (1 << AV_CHAN_FRONT_LEFT),
            
            /// <summary>AV_CH_FRONT_LEFT_OF_CENTER = (1ULL &lt;&lt; AV_CHAN_FRONT_LEFT_OF_CENTER )</summary>
            FrontLeftOfCenter = (1 << AV_CHAN_FRONT_LEFT_OF_CENTER),
            
            /// <summary>AV_CH_FRONT_RIGHT = (1ULL &lt;&lt; AV_CHAN_FRONT_RIGHT          )</summary>
            FrontRight = (1 << AV_CHAN_FRONT_RIGHT),
            
            /// <summary>AV_CH_FRONT_RIGHT_OF_CENTER = (1ULL &lt;&lt; AV_CHAN_FRONT_RIGHT_OF_CENTER)</summary>
            FrontRightOfCenter = (1 << AV_CHAN_FRONT_RIGHT_OF_CENTER),
            
            /// <summary>AV_CH_LAYOUT_2_1 = (AV_CH_LAYOUT_STEREO|AV_CH_BACK_CENTER)</summary>
            Layout_2_1 = (LayoutStereo | BackCenter),
            
            /// <summary>AV_CH_LAYOUT_2_2 = (AV_CH_LAYOUT_STEREO|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT)</summary>
            Layout_2_2 = (LayoutStereo | SideLeft | SideRight),
            
            /// <summary>AV_CH_LAYOUT_22POINT2 = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER|AV_CH_BACK_CENTER|AV_CH_LOW_FREQUENCY_2|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT|AV_CH_TOP_FRONT_LEFT|AV_CH_TOP_FRONT_RIGHT|AV_CH_TOP_FRONT_CENTER|AV_CH_TOP_CENTER|AV_CH_TOP_BACK_LEFT|AV_CH_TOP_BACK_RIGHT|AV_CH_TOP_SIDE_LEFT|AV_CH_TOP_SIDE_RIGHT|AV_CH_TOP_BACK_CENTER|AV_CH_BOTTOM_FRONT_CENTER|AV_CH_BOTTOM_FRONT_LEFT|AV_CH_BOTTOM_FRONT_RIGHT)</summary>
            Layout_22POINT2 = (Layout_5POINT1Back | FrontLeftOfCenter | FrontRightOfCenter | BackCenter | LowFrequency_2 | SideLeft | SideRight | TopFrontLeft | TopFrontRight | TopFrontCenter | TopCenter | TopBackLeft | TopBackRight | TopSideLeft | TopSideRight | TopBackCenter | BottomFrontCenter | BottomFrontLeft | BottomFrontRight),
            
            /// <summary>AV_CH_LAYOUT_2POINT1 = (AV_CH_LAYOUT_STEREO|AV_CH_LOW_FREQUENCY)</summary>
            Layout_2POINT1 = (LayoutStereo | LowFrequency),
            
            /// <summary>AV_CH_LAYOUT_3POINT1 = (AV_CH_LAYOUT_SURROUND|AV_CH_LOW_FREQUENCY)</summary>
            Layout_3POINT1 = (LayoutSurround | LowFrequency),
            
            /// <summary>AV_CH_LAYOUT_4POINT0 = (AV_CH_LAYOUT_SURROUND|AV_CH_BACK_CENTER)</summary>
            Layout_4POINT0 = (LayoutSurround | BackCenter),
            
            /// <summary>AV_CH_LAYOUT_4POINT1 = (AV_CH_LAYOUT_4POINT0|AV_CH_LOW_FREQUENCY)</summary>
            Layout_4POINT1 = (Layout_4POINT0 | LowFrequency),
            
            /// <summary>AV_CH_LAYOUT_5POINT0 = (AV_CH_LAYOUT_SURROUND|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT)</summary>
            Layout_5POINT0 = (LayoutSurround | SideLeft | SideRight),
            
            /// <summary>AV_CH_LAYOUT_5POINT0_BACK = (AV_CH_LAYOUT_SURROUND|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT)</summary>
            Layout_5POINT0Back = (LayoutSurround | BackLeft | BackRight),
            
            /// <summary>AV_CH_LAYOUT_5POINT1 = (AV_CH_LAYOUT_5POINT0|AV_CH_LOW_FREQUENCY)</summary>
            Layout_5POINT1 = (Layout_5POINT0 | LowFrequency),
            
            /// <summary>AV_CH_LAYOUT_5POINT1_BACK = (AV_CH_LAYOUT_5POINT0_BACK|AV_CH_LOW_FREQUENCY)</summary>
            Layout_5POINT1Back = (Layout_5POINT0Back | LowFrequency),
            
            /// <summary>AV_CH_LAYOUT_6POINT0 = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_CENTER)</summary>
            Layout_6POINT0 = (Layout_5POINT0 | BackCenter),
            
            /// <summary>AV_CH_LAYOUT_6POINT0_FRONT = (AV_CH_LAYOUT_2_2|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER)</summary>
            Layout_6POINT0Front = (Layout_2_2 | FrontLeftOfCenter | FrontRightOfCenter),
            
            /// <summary>AV_CH_LAYOUT_6POINT1 = (AV_CH_LAYOUT_5POINT1|AV_CH_BACK_CENTER)</summary>
            Layout_6POINT1 = (Layout_5POINT1 | BackCenter),
            
            /// <summary>AV_CH_LAYOUT_6POINT1_BACK = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_BACK_CENTER)</summary>
            Layout_6POINT1Back = (Layout_5POINT1Back | BackCenter),
            
            /// <summary>AV_CH_LAYOUT_6POINT1_FRONT = (AV_CH_LAYOUT_6POINT0_FRONT|AV_CH_LOW_FREQUENCY)</summary>
            Layout_6POINT1Front = (Layout_6POINT0Front | LowFrequency),
            
            /// <summary>AV_CH_LAYOUT_7POINT0 = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT)</summary>
            Layout_7POINT0 = (Layout_5POINT0 | BackLeft | BackRight),
            
            /// <summary>AV_CH_LAYOUT_7POINT0_FRONT = (AV_CH_LAYOUT_5POINT0|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER)</summary>
            Layout_7POINT0Front = (Layout_5POINT0 | FrontLeftOfCenter | FrontRightOfCenter),
            
            /// <summary>AV_CH_LAYOUT_7POINT1 = (AV_CH_LAYOUT_5POINT1|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT)</summary>
            Layout_7POINT1 = (Layout_5POINT1 | BackLeft | BackRight),
            
            /// <summary>AV_CH_LAYOUT_7POINT1_WIDE = (AV_CH_LAYOUT_5POINT1|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER)</summary>
            Layout_7POINT1Wide = (Layout_5POINT1 | FrontLeftOfCenter | FrontRightOfCenter),
            
            /// <summary>AV_CH_LAYOUT_7POINT1_WIDE_BACK = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER)</summary>
            Layout_7POINT1WideBack = (Layout_5POINT1Back | FrontLeftOfCenter | FrontRightOfCenter),
            
            /// <summary>AV_CH_LAYOUT_HEXADECAGONAL = (AV_CH_LAYOUT_OCTAGONAL|AV_CH_WIDE_LEFT|AV_CH_WIDE_RIGHT|AV_CH_TOP_BACK_LEFT|AV_CH_TOP_BACK_RIGHT|AV_CH_TOP_BACK_CENTER|AV_CH_TOP_FRONT_CENTER|AV_CH_TOP_FRONT_LEFT|AV_CH_TOP_FRONT_RIGHT)</summary>
            LayoutHexadecagonal = (LayoutOctagonal | WideLeft | WideRight | TopBackLeft | TopBackRight | TopBackCenter | TopFrontCenter | TopFrontLeft | TopFrontRight),
            
            /// <summary>AV_CH_LAYOUT_HEXAGONAL = (AV_CH_LAYOUT_5POINT0_BACK|AV_CH_BACK_CENTER)</summary>
            LayoutHexagonal = (Layout_5POINT0Back | BackCenter),
            
            /// <summary>AV_CH_LAYOUT_MONO = (AV_CH_FRONT_CENTER)</summary>
            LayoutMono = (FrontCenter),
            
            /// <summary>AV_CH_LAYOUT_NATIVE = 0x8000000000000000ULL</summary>
            LayoutNative = 0x8000000000000000,
            
            /// <summary>AV_CH_LAYOUT_OCTAGONAL = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_LEFT|AV_CH_BACK_CENTER|AV_CH_BACK_RIGHT)</summary>
            LayoutOctagonal = (Layout_5POINT0 | BackLeft | BackCenter | BackRight),
            
            /// <summary>AV_CH_LAYOUT_QUAD = (AV_CH_LAYOUT_STEREO|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT)</summary>
            LayoutQuad = (LayoutStereo | BackLeft | BackRight),
            
            /// <summary>AV_CH_LAYOUT_STEREO = (AV_CH_FRONT_LEFT|AV_CH_FRONT_RIGHT)</summary>
            LayoutStereo = (FrontLeft | FrontRight),
            
            /// <summary>AV_CH_LAYOUT_STEREO_DOWNMIX = (AV_CH_STEREO_LEFT|AV_CH_STEREO_RIGHT)</summary>
            LayoutStereoDownmix = (StereoLeft | StereoRight),
            
            /// <summary>AV_CH_LAYOUT_SURROUND = (AV_CH_LAYOUT_STEREO|AV_CH_FRONT_CENTER)</summary>
            LayoutSurround = (LayoutStereo | FrontCenter),
            
            /// <summary>AV_CH_LOW_FREQUENCY = (1ULL &lt;&lt; AV_CHAN_LOW_FREQUENCY        )</summary>
            LowFrequency = (1 << AV_CHAN_LOW_FREQUENCY),
            
            /// <summary>AV_CH_LOW_FREQUENCY_2 = (1ULL &lt;&lt; AV_CHAN_LOW_FREQUENCY_2      )</summary>
            LowFrequency_2 = (1 << AV_CHAN_LOW_FREQUENCY_2),
            
            /// <summary>AV_CH_SIDE_LEFT = (1ULL &lt;&lt; AV_CHAN_SIDE_LEFT            )</summary>
            SideLeft = (1 << AV_CHAN_SIDE_LEFT),
            
            /// <summary>AV_CH_SIDE_RIGHT = (1ULL &lt;&lt; AV_CHAN_SIDE_RIGHT           )</summary>
            SideRight = (1 << AV_CHAN_SIDE_RIGHT),
            
            /// <summary>AV_CH_STEREO_LEFT = (1ULL &lt;&lt; AV_CHAN_STEREO_LEFT          )</summary>
            StereoLeft = (1 << AV_CHAN_STEREO_LEFT),
            
            /// <summary>AV_CH_STEREO_RIGHT = (1ULL &lt;&lt; AV_CHAN_STEREO_RIGHT         )</summary>
            StereoRight = (1 << AV_CHAN_STEREO_RIGHT),
            
            /// <summary>AV_CH_SURROUND_DIRECT_LEFT = (1ULL &lt;&lt; AV_CHAN_SURROUND_DIRECT_LEFT )</summary>
            SurroundDirectLeft = (1 << AV_CHAN_SURROUND_DIRECT_LEFT),
            
            /// <summary>AV_CH_SURROUND_DIRECT_RIGHT = (1ULL &lt;&lt; AV_CHAN_SURROUND_DIRECT_RIGHT)</summary>
            SurroundDirectRight = (1 << AV_CHAN_SURROUND_DIRECT_RIGHT),
            
            /// <summary>AV_CH_TOP_BACK_CENTER = (1ULL &lt;&lt; AV_CHAN_TOP_BACK_CENTER      )</summary>
            TopBackCenter = (1 << AV_CHAN_TOP_BACK_CENTER),
            
            /// <summary>AV_CH_TOP_BACK_LEFT = (1ULL &lt;&lt; AV_CHAN_TOP_BACK_LEFT        )</summary>
            TopBackLeft = (1 << AV_CHAN_TOP_BACK_LEFT),
            
            /// <summary>AV_CH_TOP_BACK_RIGHT = (1ULL &lt;&lt; AV_CHAN_TOP_BACK_RIGHT       )</summary>
            TopBackRight = (1 << AV_CHAN_TOP_BACK_RIGHT),
            
            /// <summary>AV_CH_TOP_CENTER = (1ULL &lt;&lt; AV_CHAN_TOP_CENTER           )</summary>
            TopCenter = (1 << AV_CHAN_TOP_CENTER),
            
            /// <summary>AV_CH_TOP_FRONT_CENTER = (1ULL &lt;&lt; AV_CHAN_TOP_FRONT_CENTER     )</summary>
            TopFrontCenter = (1 << AV_CHAN_TOP_FRONT_CENTER),
            
            /// <summary>AV_CH_TOP_FRONT_LEFT = (1ULL &lt;&lt; AV_CHAN_TOP_FRONT_LEFT       )</summary>
            TopFrontLeft = (1 << AV_CHAN_TOP_FRONT_LEFT),
            
            /// <summary>AV_CH_TOP_FRONT_RIGHT = (1ULL &lt;&lt; AV_CHAN_TOP_FRONT_RIGHT      )</summary>
            TopFrontRight = (1 << AV_CHAN_TOP_FRONT_RIGHT),
            
            /// <summary>AV_CH_TOP_SIDE_LEFT = (1ULL &lt;&lt; AV_CHAN_TOP_SIDE_LEFT        )</summary>
            TopSideLeft = (1 << AV_CHAN_TOP_SIDE_LEFT),
            
            /// <summary>AV_CH_TOP_SIDE_RIGHT = (1ULL &lt;&lt; AV_CHAN_TOP_SIDE_RIGHT       )</summary>
            TopSideRight = (1 << AV_CHAN_TOP_SIDE_RIGHT),
            
            /// <summary>AV_CH_WIDE_LEFT = (1ULL &lt;&lt; AV_CHAN_WIDE_LEFT            )</summary>
            WideLeft = (1 << AV_CHAN_WIDE_LEFT),
            
            /// <summary>AV_CH_WIDE_RIGHT = (1ULL &lt;&lt; AV_CHAN_WIDE_RIGHT           )</summary>
            WideRight = (1 << AV_CHAN_WIDE_RIGHT),
        }
        
        /// <summary>Macro enum, prefix: AV_CODEC_CAP_</summary>
        public enum CodecCompability : uint
        {
            /// <summary>AV_CODEC_CAP_AUTO_THREADS = AV_CODEC_CAP_OTHER_THREADS</summary>
            AutoThreads = OtherThreads,
            
            /// <summary>AV_CODEC_CAP_AVOID_PROBING = (1 &lt;&lt; 17)</summary>
            AvoidProbing = (1 << 17),
            
            /// <summary>AV_CODEC_CAP_CHANNEL_CONF = (1 &lt;&lt; 10)</summary>
            ChannelConf = (1 << 10),
            
            /// <summary>AV_CODEC_CAP_DELAY = (1 &lt;&lt;  5)</summary>
            Delay = (1 << 5),
            
            /// <summary>AV_CODEC_CAP_DR1 = (1 &lt;&lt;  1)</summary>
            Dr1 = (1 << 1),
            
            /// <summary>AV_CODEC_CAP_DRAW_HORIZ_BAND = (1 &lt;&lt;  0)</summary>
            DrawHorizBand = (1 << 0),
            
            /// <summary>AV_CODEC_CAP_ENCODER_FLUSH = (1 &lt;&lt; 21)</summary>
            EncoderFlush = (1 << 21),
            
            /// <summary>AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE = (1 &lt;&lt; 20)</summary>
            EncoderReorderedOpaque = (1 << 20),
            
            /// <summary>AV_CODEC_CAP_EXPERIMENTAL = (1 &lt;&lt;  9)</summary>
            Experimental = (1 << 9),
            
            /// <summary>AV_CODEC_CAP_FRAME_THREADS = (1 &lt;&lt; 12)</summary>
            FrameThreads = (1 << 12),
            
            /// <summary>AV_CODEC_CAP_HARDWARE = (1 &lt;&lt; 18)</summary>
            Hardware = (1 << 18),
            
            /// <summary>AV_CODEC_CAP_HYBRID = (1 &lt;&lt; 19)</summary>
            Hybrid = (1 << 19),
            
            /// <summary>AV_CODEC_CAP_INTRA_ONLY = 0x40000000</summary>
            IntraOnly = 0x40000000,
            
            /// <summary>AV_CODEC_CAP_LOSSLESS = 0x80000000</summary>
            Lossless = 0x80000000,
            
            /// <summary>AV_CODEC_CAP_OTHER_THREADS = (1 &lt;&lt; 15)</summary>
            OtherThreads = (1 << 15),
            
            /// <summary>AV_CODEC_CAP_PARAM_CHANGE = (1 &lt;&lt; 14)</summary>
            ParamChange = (1 << 14),
            
            /// <summary>AV_CODEC_CAP_SLICE_THREADS = (1 &lt;&lt; 13)</summary>
            SliceThreads = (1 << 13),
            
            /// <summary>AV_CODEC_CAP_SMALL_LAST_FRAME = (1 &lt;&lt;  6)</summary>
            SmallLastFrame = (1 << 6),
            
            /// <summary>AV_CODEC_CAP_SUBFRAMES = (1 &lt;&lt;  8)</summary>
            Subframes = (1 << 8),
            
            /// <summary>AV_CODEC_CAP_TRUNCATED = (1 &lt;&lt;  3)</summary>
            Truncated = (1 << 3),
            
            /// <summary>AV_CODEC_CAP_VARIABLE_FRAME_SIZE = (1 &lt;&lt; 16)</summary>
            VariableFrameSize = (1 << 16),
        }
        
        /// <summary>Macro enum, prefix: AV_CODEC_FLAG_</summary>
        [Flags]
        public enum CodecFlags
        {
            /// <summary>AV_CODEC_FLAG_4MV = (1 &lt;&lt;  2)</summary>
            _4MV = (1 << 2),
            
            /// <summary>AV_CODEC_FLAG_AC_PRED = (1 &lt;&lt; 24)</summary>
            AcPred = (1 << 24),
            
            /// <summary>AV_CODEC_FLAG_BITEXACT = (1 &lt;&lt; 23)</summary>
            Bitexact = (1 << 23),
            
            /// <summary>AV_CODEC_FLAG_CLOSED_GOP = (1U &lt;&lt; 31)</summary>
            ClosedGop = (1 << 31),
            
            /// <summary>AV_CODEC_FLAG_DROPCHANGED = (1 &lt;&lt;  5)</summary>
            Dropchanged = (1 << 5),
            
            /// <summary>AV_CODEC_FLAG_GLOBAL_HEADER = (1 &lt;&lt; 22)</summary>
            GlobalHeader = (1 << 22),
            
            /// <summary>AV_CODEC_FLAG_GRAY = (1 &lt;&lt; 13)</summary>
            Gray = (1 << 13),
            
            /// <summary>AV_CODEC_FLAG_INTERLACED_DCT = (1 &lt;&lt; 18)</summary>
            InterlacedDct = (1 << 18),
            
            /// <summary>AV_CODEC_FLAG_INTERLACED_ME = (1 &lt;&lt; 29)</summary>
            InterlacedMe = (1 << 29),
            
            /// <summary>AV_CODEC_FLAG_LOOP_FILTER = (1 &lt;&lt; 11)</summary>
            LoopFilter = (1 << 11),
            
            /// <summary>AV_CODEC_FLAG_LOW_DELAY = (1 &lt;&lt; 19)</summary>
            LowDelay = (1 << 19),
            
            /// <summary>AV_CODEC_FLAG_OUTPUT_CORRUPT = (1 &lt;&lt;  3)</summary>
            OutputCorrupt = (1 << 3),
            
            /// <summary>AV_CODEC_FLAG_PASS1 = (1 &lt;&lt;  9)</summary>
            Pass1 = (1 << 9),
            
            /// <summary>AV_CODEC_FLAG_PASS2 = (1 &lt;&lt; 10)</summary>
            Pass2 = (1 << 10),
            
            /// <summary>AV_CODEC_FLAG_PSNR = (1 &lt;&lt; 15)</summary>
            Psnr = (1 << 15),
            
            /// <summary>AV_CODEC_FLAG_QPEL = (1 &lt;&lt;  4)</summary>
            Qpel = (1 << 4),
            
            /// <summary>AV_CODEC_FLAG_QSCALE = (1 &lt;&lt;  1)</summary>
            Qscale = (1 << 1),
            
            /// <summary>AV_CODEC_FLAG_TRUNCATED = (1 &lt;&lt; 16)</summary>
            Truncated = (1 << 16),
            
            /// <summary>AV_CODEC_FLAG_UNALIGNED = (1 &lt;&lt;  0)</summary>
            Unaligned = (1 << 0),
        }
        
        /// <summary>Macro enum, prefix: AV_CODEC_FLAG2_</summary>
        public enum CodecFlags2
        {
            /// <summary>AV_CODEC_FLAG2_CHUNKS = (1 &lt;&lt; 15)</summary>
            Chunks = (1 << 15),
            
            /// <summary>AV_CODEC_FLAG2_DROP_FRAME_TIMECODE = (1 &lt;&lt; 13)</summary>
            DropFrameTimecode = (1 << 13),
            
            /// <summary>AV_CODEC_FLAG2_EXPORT_MVS = (1 &lt;&lt; 28)</summary>
            ExportMvs = (1 << 28),
            
            /// <summary>AV_CODEC_FLAG2_FAST = (1 &lt;&lt;  0)</summary>
            Fast = (1 << 0),
            
            /// <summary>AV_CODEC_FLAG2_IGNORE_CROP = (1 &lt;&lt; 16)</summary>
            IgnoreCrop = (1 << 16),
            
            /// <summary>AV_CODEC_FLAG2_LOCAL_HEADER = (1 &lt;&lt;  3)</summary>
            LocalHeader = (1 << 3),
            
            /// <summary>AV_CODEC_FLAG2_NO_OUTPUT = (1 &lt;&lt;  2)</summary>
            NoOutput = (1 << 2),
            
            /// <summary>AV_CODEC_FLAG2_RO_FLUSH_NOOP = (1 &lt;&lt; 30)</summary>
            RoFlushNoop = (1 << 30),
            
            /// <summary>AV_CODEC_FLAG2_SHOW_ALL = (1 &lt;&lt; 22)</summary>
            ShowAll = (1 << 22),
            
            /// <summary>AV_CODEC_FLAG2_SKIP_MANUAL = (1 &lt;&lt; 29)</summary>
            SkipManual = (1 << 29),
        }
        
        /// <summary>Macro enum, prefix: AV_CPU_FLAG_</summary>
        [Flags]
        public enum CpuFlags : uint
        {
            /// <summary>AV_CPU_FLAG_3DNOW = 0x0004</summary>
            _3DNOW = 0x0004,
            
            /// <summary>AV_CPU_FLAG_3DNOWEXT = 0x0020</summary>
            _3DNOWEXT = 0x0020,
            
            /// <summary>AV_CPU_FLAG_AESNI = 0x80000</summary>
            Aesni = 0x80000,
            
            /// <summary>AV_CPU_FLAG_ALTIVEC = 0x0001</summary>
            Altivec = 0x0001,
            
            /// <summary>AV_CPU_FLAG_ARMV5TE = (1 &lt;&lt; 0)</summary>
            Armv5te = (1 << 0),
            
            /// <summary>AV_CPU_FLAG_ARMV6 = (1 &lt;&lt; 1)</summary>
            Armv6 = (1 << 1),
            
            /// <summary>AV_CPU_FLAG_ARMV6T2 = (1 &lt;&lt; 2)</summary>
            Armv6t2 = (1 << 2),
            
            /// <summary>AV_CPU_FLAG_ARMV8 = (1 &lt;&lt; 6)</summary>
            Armv8 = (1 << 6),
            
            /// <summary>AV_CPU_FLAG_ATOM = 0x10000000</summary>
            Atom = 0x10000000,
            
            /// <summary>AV_CPU_FLAG_AVX = 0x4000</summary>
            Avx = 0x4000,
            
            /// <summary>AV_CPU_FLAG_AVX2 = 0x8000</summary>
            Avx2 = 0x8000,
            
            /// <summary>AV_CPU_FLAG_AVX512 = 0x100000</summary>
            Avx512 = 0x100000,
            
            /// <summary>AV_CPU_FLAG_AVX512ICL = 0x200000</summary>
            Avx512icl = 0x200000,
            
            /// <summary>AV_CPU_FLAG_AVXSLOW = 0x8000000</summary>
            Avxslow = 0x8000000,
            
            /// <summary>AV_CPU_FLAG_BMI1 = 0x20000</summary>
            Bmi1 = 0x20000,
            
            /// <summary>AV_CPU_FLAG_BMI2 = 0x40000</summary>
            Bmi2 = 0x40000,
            
            /// <summary>AV_CPU_FLAG_CMOV = 0x1000</summary>
            Cmov = 0x1000,
            
            /// <summary>AV_CPU_FLAG_FMA3 = 0x10000</summary>
            Fma3 = 0x10000,
            
            /// <summary>AV_CPU_FLAG_FMA4 = 0x0800</summary>
            Fma4 = 0x0800,
            
            /// <summary>AV_CPU_FLAG_FORCE = 0x80000000</summary>
            Force = 0x80000000,
            
            /// <summary>AV_CPU_FLAG_LASX = (1 &lt;&lt; 1)</summary>
            Lasx = (1 << 1),
            
            /// <summary>AV_CPU_FLAG_LSX = (1 &lt;&lt; 0)</summary>
            Lsx = (1 << 0),
            
            /// <summary>AV_CPU_FLAG_MMI = (1 &lt;&lt; 0)</summary>
            Mmi = (1 << 0),
            
            /// <summary>AV_CPU_FLAG_MMX = 0x0001</summary>
            Mmx = 0x0001,
            
            /// <summary>AV_CPU_FLAG_MMX2 = 0x0002</summary>
            Mmx2 = 0x0002,
            
            /// <summary>AV_CPU_FLAG_MMXEXT = 0x0002</summary>
            Mmxext = 0x0002,
            
            /// <summary>AV_CPU_FLAG_MSA = (1 &lt;&lt; 1)</summary>
            Msa = (1 << 1),
            
            /// <summary>AV_CPU_FLAG_NEON = (1 &lt;&lt; 5)</summary>
            Neon = (1 << 5),
            
            /// <summary>AV_CPU_FLAG_POWER8 = 0x0004</summary>
            Power8 = 0x0004,
            
            /// <summary>AV_CPU_FLAG_SETEND = (1 &lt;&lt;16)</summary>
            Setend = (1 << 16),
            
            /// <summary>AV_CPU_FLAG_SLOW_GATHER = 0x2000000</summary>
            SlowGather = 0x2000000,
            
            /// <summary>AV_CPU_FLAG_SSE = 0x0008</summary>
            Sse = 0x0008,
            
            /// <summary>AV_CPU_FLAG_SSE2 = 0x0010</summary>
            Sse2 = 0x0010,
            
            /// <summary>AV_CPU_FLAG_SSE2SLOW = 0x40000000</summary>
            Sse2slow = 0x40000000,
            
            /// <summary>AV_CPU_FLAG_SSE3 = 0x0040</summary>
            Sse3 = 0x0040,
            
            /// <summary>AV_CPU_FLAG_SSE3SLOW = 0x20000000</summary>
            Sse3slow = 0x20000000,
            
            /// <summary>AV_CPU_FLAG_SSE4 = 0x0100</summary>
            Sse4 = 0x0100,
            
            /// <summary>AV_CPU_FLAG_SSE42 = 0x0200</summary>
            Sse42 = 0x0200,
            
            /// <summary>AV_CPU_FLAG_SSSE3 = 0x0080</summary>
            Ssse3 = 0x0080,
            
            /// <summary>AV_CPU_FLAG_SSSE3SLOW = 0x4000000</summary>
            Ssse3slow = 0x4000000,
            
            /// <summary>AV_CPU_FLAG_VFP = (1 &lt;&lt; 3)</summary>
            Vfp = (1 << 3),
            
            /// <summary>AV_CPU_FLAG_VFP_VM = (1 &lt;&lt; 7)</summary>
            VfpVm = (1 << 7),
            
            /// <summary>AV_CPU_FLAG_VFPV3 = (1 &lt;&lt; 4)</summary>
            Vfpv3 = (1 << 4),
            
            /// <summary>AV_CPU_FLAG_VSX = 0x0002</summary>
            Vsx = 0x0002,
            
            /// <summary>AV_CPU_FLAG_XOP = 0x0400</summary>
            Xop = 0x0400,
        }
        
        /// <summary>Macro enum, prefix: AV_LOG_</summary>
        public enum LogLevel
        {
            /// <summary>AV_LOG_DEBUG = 48</summary>
            Debug = 48,
            
            /// <summary>AV_LOG_ERROR = 16</summary>
            Error = 16,
            
            /// <summary>AV_LOG_FATAL = 8</summary>
            Fatal = 8,
            
            /// <summary>AV_LOG_INFO = 32</summary>
            Info = 32,
            
            /// <summary>AV_LOG_MAX_OFFSET = (AV_LOG_TRACE - AV_LOG_QUIET)</summary>
            MaxOffset = (Trace - Quiet),
            
            /// <summary>AV_LOG_PANIC = 0</summary>
            Panic = 0,
            
            /// <summary>AV_LOG_QUIET = -8</summary>
            Quiet = -8,
            
            /// <summary>AV_LOG_TRACE = 56</summary>
            Trace = 56,
            
            /// <summary>AV_LOG_VERBOSE = 40</summary>
            Verbose = 40,
            
            /// <summary>AV_LOG_WARNING = 24</summary>
            Warning = 24,
        }
        
        /// <summary>Macro enum, prefix: AV_LOG_</summary>
        [Flags]
        public enum LogFlags
        {
            /// <summary>AV_LOG_PRINT_LEVEL = 2</summary>
            PrintLevel = 2,
            
            /// <summary>AV_LOG_SKIP_REPEATED = 1</summary>
            SkipRepeated = 1,
        }
        
        /// <summary>Macro enum, prefix: AV_OPT_FLAG_</summary>
        [Flags]
        public enum OptionFlags
        {
            /// <summary>AV_OPT_FLAG_AUDIO_PARAM = 8</summary>
            AudioParam = 8,
            
            /// <summary>AV_OPT_FLAG_BSF_PARAM = (1&lt;&lt;8)</summary>
            BsfParam = (1 << 8),
            
            /// <summary>AV_OPT_FLAG_CHILD_CONSTS = (1&lt;&lt;18)</summary>
            ChildConsts = (1 << 18),
            
            /// <summary>AV_OPT_FLAG_DECODING_PARAM = 2</summary>
            DecodingParam = 2,
            
            /// <summary>AV_OPT_FLAG_DEPRECATED = (1&lt;&lt;17)</summary>
            Deprecated = (1 << 17),
            
            /// <summary>AV_OPT_FLAG_ENCODING_PARAM = 1</summary>
            EncodingParam = 1,
            
            /// <summary>AV_OPT_FLAG_EXPORT = 64</summary>
            Export = 64,
            
            /// <summary>AV_OPT_FLAG_FILTERING_PARAM = (1&lt;&lt;16)</summary>
            FilteringParam = (1 << 16),
            
            /// <summary>AV_OPT_FLAG_READONLY = 128</summary>
            Readonly = 128,
            
            /// <summary>AV_OPT_FLAG_RUNTIME_PARAM = (1&lt;&lt;15)</summary>
            RuntimeParam = (1 << 15),
            
            /// <summary>AV_OPT_FLAG_SUBTITLE_PARAM = 32</summary>
            SubtitleParam = 32,
            
            /// <summary>AV_OPT_FLAG_VIDEO_PARAM = 16</summary>
            VideoParam = 16,
        }
        
        /// <summary>Macro enum, prefix: AV_PIX_FMT_FLAG_</summary>
        [Flags]
        public enum PixelFormatFlags
        {
            /// <summary>AV_PIX_FMT_FLAG_ALPHA = (1 &lt;&lt; 7)</summary>
            Alpha = (1 << 7),
            
            /// <summary>AV_PIX_FMT_FLAG_BAYER = (1 &lt;&lt; 8)</summary>
            Bayer = (1 << 8),
            
            /// <summary>AV_PIX_FMT_FLAG_BE = (1 &lt;&lt; 0)</summary>
            Be = (1 << 0),
            
            /// <summary>AV_PIX_FMT_FLAG_BITSTREAM = (1 &lt;&lt; 2)</summary>
            Bitstream = (1 << 2),
            
            /// <summary>AV_PIX_FMT_FLAG_FLOAT = (1 &lt;&lt; 9)</summary>
            Float = (1 << 9),
            
            /// <summary>AV_PIX_FMT_FLAG_HWACCEL = (1 &lt;&lt; 3)</summary>
            Hwaccel = (1 << 3),
            
            /// <summary>AV_PIX_FMT_FLAG_PAL = (1 &lt;&lt; 1)</summary>
            Pal = (1 << 1),
            
            /// <summary>AV_PIX_FMT_FLAG_PLANAR = (1 &lt;&lt; 4)</summary>
            Planar = (1 << 4),
            
            /// <summary>AV_PIX_FMT_FLAG_RGB = (1 &lt;&lt; 5)</summary>
            Rgb = (1 << 5),
        }
        
        /// <summary>Macro enum, prefix: AV_PKT_FLAG_</summary>
        [Flags]
        public enum PacketFlags : uint
        {
            /// <summary>AV_PKT_FLAG_CORRUPT = 0x0002</summary>
            Corrupt = 0x0002,
            
            /// <summary>AV_PKT_FLAG_DISCARD = 0x0004</summary>
            Discard = 0x0004,
            
            /// <summary>AV_PKT_FLAG_DISPOSABLE = 0x0010</summary>
            Disposable = 0x0010,
            
            /// <summary>AV_PKT_FLAG_KEY = 0x0001</summary>
            Key = 0x0001,
            
            /// <summary>AV_PKT_FLAG_TRUSTED = 0x0008</summary>
            Trusted = 0x0008,
        }
        
        /// <summary>Macro enum, prefix: AVFMT_FLAG_</summary>
        [Flags]
        public enum FormatFlags : uint
        {
            /// <summary>AVFMT_FLAG_AUTO_BSF = 0x200000</summary>
            AutoBsf = 0x200000,
            
            /// <summary>AVFMT_FLAG_BITEXACT = 0x0400</summary>
            Bitexact = 0x0400,
            
            /// <summary>AVFMT_FLAG_CUSTOM_IO = 0x0080</summary>
            CustomIo = 0x0080,
            
            /// <summary>AVFMT_FLAG_DISCARD_CORRUPT = 0x0100</summary>
            DiscardCorrupt = 0x0100,
            
            /// <summary>AVFMT_FLAG_FAST_SEEK = 0x80000</summary>
            FastSeek = 0x80000,
            
            /// <summary>AVFMT_FLAG_FLUSH_PACKETS = 0x0200</summary>
            FlushPackets = 0x0200,
            
            /// <summary>AVFMT_FLAG_GENPTS = 0x0001</summary>
            Genpts = 0x0001,
            
            /// <summary>AVFMT_FLAG_IGNDTS = 0x0008</summary>
            Igndts = 0x0008,
            
            /// <summary>AVFMT_FLAG_IGNIDX = 0x0002</summary>
            Ignidx = 0x0002,
            
            /// <summary>AVFMT_FLAG_NOBUFFER = 0x0040</summary>
            Nobuffer = 0x0040,
            
            /// <summary>AVFMT_FLAG_NOFILLIN = 0x0010</summary>
            Nofillin = 0x0010,
            
            /// <summary>AVFMT_FLAG_NONBLOCK = 0x0004</summary>
            Nonblock = 0x0004,
            
            /// <summary>AVFMT_FLAG_NOPARSE = 0x0020</summary>
            Noparse = 0x0020,
            
            /// <summary>AVFMT_FLAG_PRIV_OPT = 0x20000</summary>
            PrivOpt = 0x20000,
            
            /// <summary>AVFMT_FLAG_SHORTEST = 0x100000</summary>
            Shortest = 0x100000,
            
            /// <summary>AVFMT_FLAG_SORT_DTS = 0x10000</summary>
            SortDts = 0x10000,
        }
        
        /// <summary>Macro enum, prefix: AVIO_FLAG_</summary>
        [Flags]
        public enum IOFlags : uint
        {
            /// <summary>AVIO_FLAG_DIRECT = 0x8000</summary>
            Direct = 0x8000,
            
            /// <summary>AVIO_FLAG_NONBLOCK = 8</summary>
            Nonblock = 8,
            
            /// <summary>AVIO_FLAG_READ = 1</summary>
            Read = 1,
            
            /// <summary>AVIO_FLAG_READ_WRITE = (AVIO_FLAG_READ|AVIO_FLAG_WRITE)</summary>
            ReadWrite = (Read | Write),
            
            /// <summary>AVIO_FLAG_WRITE = 2</summary>
            Write = 2,
        }
        
        /// <summary>Macro enum, prefix: AVSEEK_FLAG_</summary>
        [Flags]
        public enum SeekFlags
        {
            /// <summary>AVSEEK_FLAG_ANY = 4</summary>
            Any = 4,
            
            /// <summary>AVSEEK_FLAG_BACKWARD = 1</summary>
            Backward = 1,
            
            /// <summary>AVSEEK_FLAG_BYTE = 2</summary>
            Byte = 2,
            
            /// <summary>AVSEEK_FLAG_FRAME = 8</summary>
            Frame = 8,
        }
        
        /// <summary>Macro enum, prefix: FF_CMP_</summary>
        public enum FFComparison
        {
            /// <summary>FF_CMP_BIT = 5</summary>
            Bit = 5,
            
            /// <summary>FF_CMP_CHROMA = 256</summary>
            Chroma = 256,
            
            /// <summary>FF_CMP_DCT = 3</summary>
            Dct = 3,
            
            /// <summary>FF_CMP_DCT264 = 14</summary>
            Dct264 = 14,
            
            /// <summary>FF_CMP_DCTMAX = 13</summary>
            Dctmax = 13,
            
            /// <summary>FF_CMP_MEDIAN_SAD = 15</summary>
            MedianSad = 15,
            
            /// <summary>FF_CMP_NSSE = 10</summary>
            Nsse = 10,
            
            /// <summary>FF_CMP_PSNR = 4</summary>
            Psnr = 4,
            
            /// <summary>FF_CMP_RD = 6</summary>
            Rd = 6,
            
            /// <summary>FF_CMP_SAD = 0</summary>
            Sad = 0,
            
            /// <summary>FF_CMP_SATD = 2</summary>
            Satd = 2,
            
            /// <summary>FF_CMP_SSE = 1</summary>
            Sse = 1,
            
            /// <summary>FF_CMP_VSAD = 8</summary>
            Vsad = 8,
            
            /// <summary>FF_CMP_VSSE = 9</summary>
            Vsse = 9,
            
            /// <summary>FF_CMP_W53 = 11</summary>
            W53 = 11,
            
            /// <summary>FF_CMP_W97 = 12</summary>
            W97 = 12,
            
            /// <summary>FF_CMP_ZERO = 7</summary>
            Zero = 7,
        }
        
        /// <summary>Macro enum, prefix: FF_MB_DECISION_</summary>
        public enum FFMacroblockDecision
        {
            /// <summary>FF_MB_DECISION_BITS = 1</summary>
            Bits = 1,
            
            /// <summary>FF_MB_DECISION_RD = 2</summary>
            Rd = 2,
            
            /// <summary>FF_MB_DECISION_SIMPLE = 0</summary>
            Simple = 0,
        }
        
        /// <summary>Macro enum, prefix: FF_PROFILE_</summary>
        public enum FFProfile : uint
        {
            /// <summary>FF_PROFILE_AAC_ELD = 38</summary>
            AacEld = 38,
            
            /// <summary>FF_PROFILE_AAC_HE = 4</summary>
            AacHe = 4,
            
            /// <summary>FF_PROFILE_AAC_HE_V2 = 28</summary>
            AacHeV2 = 28,
            
            /// <summary>FF_PROFILE_AAC_LD = 22</summary>
            AacLd = 22,
            
            /// <summary>FF_PROFILE_AAC_LOW = 1</summary>
            AacLow = 1,
            
            /// <summary>FF_PROFILE_AAC_LTP = 3</summary>
            AacLtp = 3,
            
            /// <summary>FF_PROFILE_AAC_MAIN = 0</summary>
            AacMain = 0,
            
            /// <summary>FF_PROFILE_AAC_SSR = 2</summary>
            AacSsr = 2,
            
            /// <summary>FF_PROFILE_ARIB_PROFILE_A = 0</summary>
            AribProfileA = 0,
            
            /// <summary>FF_PROFILE_ARIB_PROFILE_C = 1</summary>
            AribProfileC = 1,
            
            /// <summary>FF_PROFILE_AV1_HIGH = 1</summary>
            Av1High = 1,
            
            /// <summary>FF_PROFILE_AV1_MAIN = 0</summary>
            Av1Main = 0,
            
            /// <summary>FF_PROFILE_AV1_PROFESSIONAL = 2</summary>
            Av1Professional = 2,
            
            /// <summary>FF_PROFILE_DNXHD = 0</summary>
            Dnxhd = 0,
            
            /// <summary>FF_PROFILE_DNXHR_444 = 5</summary>
            Dnxhr_444 = 5,
            
            /// <summary>FF_PROFILE_DNXHR_HQ = 3</summary>
            DnxhrHq = 3,
            
            /// <summary>FF_PROFILE_DNXHR_HQX = 4</summary>
            DnxhrHqx = 4,
            
            /// <summary>FF_PROFILE_DNXHR_LB = 1</summary>
            DnxhrLb = 1,
            
            /// <summary>FF_PROFILE_DNXHR_SQ = 2</summary>
            DnxhrSq = 2,
            
            /// <summary>FF_PROFILE_DTS = 20</summary>
            Dts = 20,
            
            /// <summary>FF_PROFILE_DTS_96_24 = 40</summary>
            Dts_96_24 = 40,
            
            /// <summary>FF_PROFILE_DTS_ES = 30</summary>
            DtsEs = 30,
            
            /// <summary>FF_PROFILE_DTS_EXPRESS = 70</summary>
            DtsExpress = 70,
            
            /// <summary>FF_PROFILE_DTS_HD_HRA = 50</summary>
            DtsHdHra = 50,
            
            /// <summary>FF_PROFILE_DTS_HD_MA = 60</summary>
            DtsHdMa = 60,
            
            /// <summary>FF_PROFILE_H264_BASELINE = 66</summary>
            H264Baseline = 66,
            
            /// <summary>FF_PROFILE_H264_CAVLC_444 = 44</summary>
            H264Cavlc_444 = 44,
            
            /// <summary>FF_PROFILE_H264_CONSTRAINED = (1&lt;&lt;9)</summary>
            H264Constrained = (1 << 9),
            
            /// <summary>FF_PROFILE_H264_CONSTRAINED_BASELINE = (66|FF_PROFILE_H264_CONSTRAINED)</summary>
            H264ConstrainedBaseline = (66 | H264Constrained),
            
            /// <summary>FF_PROFILE_H264_EXTENDED = 88</summary>
            H264Extended = 88,
            
            /// <summary>FF_PROFILE_H264_HIGH = 100</summary>
            H264High = 100,
            
            /// <summary>FF_PROFILE_H264_HIGH_10 = 110</summary>
            H264High_10 = 110,
            
            /// <summary>FF_PROFILE_H264_HIGH_10_INTRA = (110|FF_PROFILE_H264_INTRA)</summary>
            H264High_10Intra = (110 | H264Intra),
            
            /// <summary>FF_PROFILE_H264_HIGH_422 = 122</summary>
            H264High_422 = 122,
            
            /// <summary>FF_PROFILE_H264_HIGH_422_INTRA = (122|FF_PROFILE_H264_INTRA)</summary>
            H264High_422Intra = (122 | H264Intra),
            
            /// <summary>FF_PROFILE_H264_HIGH_444 = 144</summary>
            H264High_444 = 144,
            
            /// <summary>FF_PROFILE_H264_HIGH_444_INTRA = (244|FF_PROFILE_H264_INTRA)</summary>
            H264High_444Intra = (244 | H264Intra),
            
            /// <summary>FF_PROFILE_H264_HIGH_444_PREDICTIVE = 244</summary>
            H264High_444Predictive = 244,
            
            /// <summary>FF_PROFILE_H264_INTRA = (1&lt;&lt;11)</summary>
            H264Intra = (1 << 11),
            
            /// <summary>FF_PROFILE_H264_MAIN = 77</summary>
            H264Main = 77,
            
            /// <summary>FF_PROFILE_H264_MULTIVIEW_HIGH = 118</summary>
            H264MultiviewHigh = 118,
            
            /// <summary>FF_PROFILE_H264_STEREO_HIGH = 128</summary>
            H264StereoHigh = 128,
            
            /// <summary>FF_PROFILE_HEVC_MAIN = 1</summary>
            HevcMain = 1,
            
            /// <summary>FF_PROFILE_HEVC_MAIN_10 = 2</summary>
            HevcMain_10 = 2,
            
            /// <summary>FF_PROFILE_HEVC_MAIN_STILL_PICTURE = 3</summary>
            HevcMainStillPicture = 3,
            
            /// <summary>FF_PROFILE_HEVC_REXT = 4</summary>
            HevcRext = 4,
            
            /// <summary>FF_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION = 32768</summary>
            Jpeg2000CstreamNoRestriction = 32768,
            
            /// <summary>FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 = 1</summary>
            Jpeg2000CstreamRestriction_0 = 1,
            
            /// <summary>FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 = 2</summary>
            Jpeg2000CstreamRestriction_1 = 2,
            
            /// <summary>FF_PROFILE_JPEG2000_DCINEMA_2K = 3</summary>
            Jpeg2000Dcinema_2K = 3,
            
            /// <summary>FF_PROFILE_JPEG2000_DCINEMA_4K = 4</summary>
            Jpeg2000Dcinema_4K = 4,
            
            /// <summary>FF_PROFILE_KLVA_ASYNC = 1</summary>
            KlvaAsync = 1,
            
            /// <summary>FF_PROFILE_KLVA_SYNC = 0</summary>
            KlvaSync = 0,
            
            /// <summary>FF_PROFILE_MJPEG_HUFFMAN_BASELINE_DCT = 0xc0</summary>
            MjpegHuffmanBaselineDct = 0xc0,
            
            /// <summary>FF_PROFILE_MJPEG_HUFFMAN_EXTENDED_SEQUENTIAL_DCT = 0xc1</summary>
            MjpegHuffmanExtendedSequentialDct = 0xc1,
            
            /// <summary>FF_PROFILE_MJPEG_HUFFMAN_LOSSLESS = 0xc3</summary>
            MjpegHuffmanLossless = 0xc3,
            
            /// <summary>FF_PROFILE_MJPEG_HUFFMAN_PROGRESSIVE_DCT = 0xc2</summary>
            MjpegHuffmanProgressiveDct = 0xc2,
            
            /// <summary>FF_PROFILE_MJPEG_JPEG_LS = 0xf7</summary>
            MjpegJpegLs = 0xf7,
            
            /// <summary>FF_PROFILE_MPEG2_422 = 0</summary>
            Mpeg2_422 = 0,
            
            /// <summary>FF_PROFILE_MPEG2_AAC_HE = 131</summary>
            Mpeg2AacHe = 131,
            
            /// <summary>FF_PROFILE_MPEG2_AAC_LOW = 128</summary>
            Mpeg2AacLow = 128,
            
            /// <summary>FF_PROFILE_MPEG2_HIGH = 1</summary>
            Mpeg2High = 1,
            
            /// <summary>FF_PROFILE_MPEG2_MAIN = 4</summary>
            Mpeg2Main = 4,
            
            /// <summary>FF_PROFILE_MPEG2_SIMPLE = 5</summary>
            Mpeg2Simple = 5,
            
            /// <summary>FF_PROFILE_MPEG2_SNR_SCALABLE = 3</summary>
            Mpeg2SnrScalable = 3,
            
            /// <summary>FF_PROFILE_MPEG2_SS = 2</summary>
            Mpeg2Ss = 2,
            
            /// <summary>FF_PROFILE_MPEG4_ADVANCED_CODING = 11</summary>
            Mpeg4AdvancedCoding = 11,
            
            /// <summary>FF_PROFILE_MPEG4_ADVANCED_CORE = 12</summary>
            Mpeg4AdvancedCore = 12,
            
            /// <summary>FF_PROFILE_MPEG4_ADVANCED_REAL_TIME = 9</summary>
            Mpeg4AdvancedRealTime = 9,
            
            /// <summary>FF_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE = 13</summary>
            Mpeg4AdvancedScalableTexture = 13,
            
            /// <summary>FF_PROFILE_MPEG4_ADVANCED_SIMPLE = 15</summary>
            Mpeg4AdvancedSimple = 15,
            
            /// <summary>FF_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE = 7</summary>
            Mpeg4BasicAnimatedTexture = 7,
            
            /// <summary>FF_PROFILE_MPEG4_CORE = 2</summary>
            Mpeg4Core = 2,
            
            /// <summary>FF_PROFILE_MPEG4_CORE_SCALABLE = 10</summary>
            Mpeg4CoreScalable = 10,
            
            /// <summary>FF_PROFILE_MPEG4_HYBRID = 8</summary>
            Mpeg4Hybrid = 8,
            
            /// <summary>FF_PROFILE_MPEG4_MAIN = 3</summary>
            Mpeg4Main = 3,
            
            /// <summary>FF_PROFILE_MPEG4_N_BIT = 4</summary>
            Mpeg4NBit = 4,
            
            /// <summary>FF_PROFILE_MPEG4_SCALABLE_TEXTURE = 5</summary>
            Mpeg4ScalableTexture = 5,
            
            /// <summary>FF_PROFILE_MPEG4_SIMPLE = 0</summary>
            Mpeg4Simple = 0,
            
            /// <summary>FF_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION = 6</summary>
            Mpeg4SimpleFaceAnimation = 6,
            
            /// <summary>FF_PROFILE_MPEG4_SIMPLE_SCALABLE = 1</summary>
            Mpeg4SimpleScalable = 1,
            
            /// <summary>FF_PROFILE_MPEG4_SIMPLE_STUDIO = 14</summary>
            Mpeg4SimpleStudio = 14,
            
            /// <summary>FF_PROFILE_PRORES_4444 = 4</summary>
            Prores_4444 = 4,
            
            /// <summary>FF_PROFILE_PRORES_HQ = 3</summary>
            ProresHq = 3,
            
            /// <summary>FF_PROFILE_PRORES_LT = 1</summary>
            ProresLt = 1,
            
            /// <summary>FF_PROFILE_PRORES_PROXY = 0</summary>
            ProresProxy = 0,
            
            /// <summary>FF_PROFILE_PRORES_STANDARD = 2</summary>
            ProresStandard = 2,
            
            /// <summary>FF_PROFILE_PRORES_XQ = 5</summary>
            ProresXq = 5,
            
            /// <summary>FF_PROFILE_RESERVED = -100</summary>
            Reserved = -100,
            
            /// <summary>FF_PROFILE_SBC_MSBC = 1</summary>
            SbcMsbc = 1,
            
            /// <summary>FF_PROFILE_UNKNOWN = -99</summary>
            Unknown = -99,
            
            /// <summary>FF_PROFILE_VC1_ADVANCED = 3</summary>
            Vc1Advanced = 3,
            
            /// <summary>FF_PROFILE_VC1_COMPLEX = 2</summary>
            Vc1Complex = 2,
            
            /// <summary>FF_PROFILE_VC1_MAIN = 1</summary>
            Vc1Main = 1,
            
            /// <summary>FF_PROFILE_VC1_SIMPLE = 0</summary>
            Vc1Simple = 0,
            
            /// <summary>FF_PROFILE_VP9_0 = 0</summary>
            Vp9_0 = 0,
            
            /// <summary>FF_PROFILE_VP9_1 = 1</summary>
            Vp9_1 = 1,
            
            /// <summary>FF_PROFILE_VP9_2 = 2</summary>
            Vp9_2 = 2,
            
            /// <summary>FF_PROFILE_VP9_3 = 3</summary>
            Vp9_3 = 3,
            
            /// <summary>FF_PROFILE_VVC_MAIN_10 = 1</summary>
            VvcMain_10 = 1,
            
            /// <summary>FF_PROFILE_VVC_MAIN_10_444 = 33</summary>
            VvcMain_10_444 = 33,
        }
        
        /// <summary>Macro enum, prefix: PARSER_FLAG_</summary>
        [Flags]
        public enum ParserFlags : uint
        {
            /// <summary>PARSER_FLAG_COMPLETE_FRAMES = 0x0001</summary>
            CompleteFrames = 0x0001,
            
            /// <summary>PARSER_FLAG_FETCHED_OFFSET = 0x0004</summary>
            FetchedOffset = 0x0004,
            
            /// <summary>PARSER_FLAG_ONCE = 0x0002</summary>
            Once = 0x0002,
            
            /// <summary>PARSER_FLAG_USE_CODEC_TS = 0x1000</summary>
            UseCodecTs = 0x1000,
        }
        
        /// <summary>Macro enum, prefix: SLICE_FLAG_</summary>
        [Flags]
        public enum CodecSliceFlags : uint
        {
            /// <summary>SLICE_FLAG_ALLOW_FIELD = 0x0002</summary>
            AllowField = 0x0002,
            
            /// <summary>SLICE_FLAG_ALLOW_PLANE = 0x0004</summary>
            AllowPlane = 0x0004,
            
            /// <summary>SLICE_FLAG_CODED_ORDER = 0x0001</summary>
            CodedOrder = 0x0001,
        }
    }
}
