using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameManager : MonoBehaviour
{
    private const float interfaceWidth = 910.0F;
    private const float interfaceHeight = 588.0F;
    private float pixelsPerUnit = 10.0F;
    private Rect workArea;

    private bool isSplashEnabled;
    private GameObject gameover1;
    private GameObject gameover2;
    private GameObject gameover3;

    private GameObject music;
    private AudioSource musicAudioSource;

    private bool isUiEnabled;
    private GameObject splogo;
    private readonly RectInt splogoRect = new RectInt(330, 17, 250, 30);
    private LineRenderer splogoLineRenderer;
    private bool splogoPressed;
    private GameObject musicbox;
    private RectInt musicboxRect = new RectInt(0, 64, 250, 30);
    private SpriteRenderer musicboxSpriteRenderer;
    private bool musicboxPressed;
    private GameObject floorbox;
    private SpriteRenderer floorboxSpriteRenderer;
    private GameObject labelf;
    private GameObject fnum;
    private SpriteRenderer fnumSpriteRenderer;
    #region Levels panel
    private GameObject level;
    private GameObject charm;
    private GameObject chlev;
    private SpriteRenderer chlevSpriteRenderer;
    private GameObject chb1;
    private SpriteRenderer chb1SpriteRenderer;
    private GameObject chb2;
    private SpriteRenderer chb2SpriteRenderer;
    private GameObject chb3;
    private SpriteRenderer chb3SpriteRenderer;
    private GameObject chb4;
    private SpriteRenderer chb4SpriteRenderer;
    private GameObject chb5;
    private SpriteRenderer chb5SpriteRenderer;
    private GameObject chb6;
    private SpriteRenderer chb6SpriteRenderer;
    private GameObject chb7;
    private SpriteRenderer chb7SpriteRenderer;
    private GameObject chb8;
    private SpriteRenderer chb8SpriteRenderer;
    private GameObject chb9;
    private SpriteRenderer chb9SpriteRenderer;
    private GameObject chb10;
    private SpriteRenderer chb10SpriteRenderer;
    private GameObject stealth;
    private GameObject stlev;
    private SpriteRenderer stlevSpriteRenderer;
    private GameObject stb1;
    private SpriteRenderer stb1SpriteRenderer;
    private GameObject stb2;
    private SpriteRenderer stb2SpriteRenderer;
    private GameObject stb3;
    private SpriteRenderer stb3SpriteRenderer;
    private GameObject stb4;
    private SpriteRenderer stb4SpriteRenderer;
    private GameObject stb5;
    private SpriteRenderer stb5SpriteRenderer;
    private GameObject stb6;
    private SpriteRenderer stb6SpriteRenderer;
    private GameObject stb7;
    private SpriteRenderer stb7SpriteRenderer;
    private GameObject stb8;
    private SpriteRenderer stb8SpriteRenderer;
    private GameObject stb9;
    private SpriteRenderer stb9SpriteRenderer;
    private GameObject stb10;
    private SpriteRenderer stb10SpriteRenderer;
    private GameObject spnknss;
    private GameObject splev;
    private SpriteRenderer splevSpriteRenderer;
    private GameObject spb1;
    private SpriteRenderer spb1SpriteRenderer;
    private GameObject spb2;
    private SpriteRenderer spb2SpriteRenderer;
    private GameObject spb3;
    private SpriteRenderer spb3SpriteRenderer;
    private GameObject spb4;
    private SpriteRenderer spb4SpriteRenderer;
    private GameObject spb5;
    private SpriteRenderer spb5SpriteRenderer;
    private GameObject spb6;
    private SpriteRenderer spb6SpriteRenderer;
    private GameObject spb7;
    private SpriteRenderer spb7SpriteRenderer;
    private GameObject spb8;
    private SpriteRenderer spb8SpriteRenderer;
    private GameObject spb9;
    private SpriteRenderer spb9SpriteRenderer;
    private GameObject spb10;
    private SpriteRenderer spb10SpriteRenderer;
    #endregion
    #region Map panel
    private GameObject c00;
    private SpriteRenderer c00SpriteRenderer;
    private GameObject c10;
    private SpriteRenderer c10SpriteRenderer;
    private GameObject c20;
    private SpriteRenderer c20SpriteRenderer;
    private GameObject c30;
    private SpriteRenderer c30SpriteRenderer;
    private GameObject c40;
    private SpriteRenderer c40SpriteRenderer;
    private GameObject c50;
    private SpriteRenderer c50SpriteRenderer;
    private GameObject c60;
    private SpriteRenderer c60SpriteRenderer;
    private GameObject c70;
    private SpriteRenderer c70SpriteRenderer;
    private GameObject c80;
    private SpriteRenderer c80SpriteRenderer;
    private GameObject c90;
    private SpriteRenderer c90SpriteRenderer;
    private GameObject ca0;
    private SpriteRenderer ca0SpriteRenderer;
    private GameObject c01;
    private SpriteRenderer c01SpriteRenderer;
    private GameObject c11;
    private readonly RectInt c11Rect = new RectInt(310, 196, 50, 50);
    private SpriteRenderer c11SpriteRenderer;
    private bool c11Pressed;
    private GameObject c21;
    private SpriteRenderer c21SpriteRenderer;
    private GameObject c31;
    private readonly RectInt c31Rect = new RectInt(370, 196, 50, 50);
    private SpriteRenderer c31SpriteRenderer;
    private bool c31Pressed;
    private GameObject c41;
    private SpriteRenderer c41SpriteRenderer;
    private GameObject c51;
    private readonly RectInt c51Rect = new RectInt(430, 196, 50, 50);
    private SpriteRenderer c51SpriteRenderer;
    private bool c51Pressed;
    private GameObject c61;
    private SpriteRenderer c61SpriteRenderer;
    private GameObject c71;
    private readonly RectInt c71Rect = new RectInt(490, 196, 50, 50);
    private SpriteRenderer c71SpriteRenderer;
    private bool c71Pressed;
    private GameObject c81;
    private SpriteRenderer c81SpriteRenderer;
    private GameObject c91;
    private readonly RectInt c91Rect = new RectInt(550, 196, 50, 50);
    private SpriteRenderer c91SpriteRenderer;
    private bool c91Pressed;
    private GameObject ca1;
    private SpriteRenderer ca1SpriteRenderer;
    private GameObject c02;
    private SpriteRenderer c02SpriteRenderer;
    private GameObject c12;
    private SpriteRenderer c12SpriteRenderer;
    private GameObject c22;
    private SpriteRenderer c22SpriteRenderer;
    private GameObject c32;
    private SpriteRenderer c32SpriteRenderer;
    private GameObject c42;
    private SpriteRenderer c42SpriteRenderer;
    private GameObject c52;
    private SpriteRenderer c52SpriteRenderer;
    private GameObject c62;
    private SpriteRenderer c62SpriteRenderer;
    private GameObject c72;
    private SpriteRenderer c72SpriteRenderer;
    private GameObject c82;
    private SpriteRenderer c82SpriteRenderer;
    private GameObject c92;
    private SpriteRenderer c92SpriteRenderer;
    private GameObject ca2;
    private SpriteRenderer ca2SpriteRenderer;
    private GameObject c03;
    private SpriteRenderer c03SpriteRenderer;
    private GameObject c13;
    private readonly RectInt c13Rect = new RectInt(310, 256, 50, 50);
    private SpriteRenderer c13SpriteRenderer;
    private bool c13Pressed;
    private GameObject c23;
    private SpriteRenderer c23SpriteRenderer;
    private GameObject c33;
    private readonly RectInt c33Rect = new RectInt(370, 256, 50, 50);
    private SpriteRenderer c33SpriteRenderer;
    private bool c33Pressed;
    private GameObject c43;
    private SpriteRenderer c43SpriteRenderer;
    private GameObject c53;
    private readonly RectInt c53Rect = new RectInt(430, 256, 50, 50);
    private SpriteRenderer c53SpriteRenderer;
    private bool c53Pressed;
    private GameObject c63;
    private SpriteRenderer c63SpriteRenderer;
    private GameObject c73;
    private readonly RectInt c73Rect = new RectInt(490, 256, 50, 50);
    private SpriteRenderer c73SpriteRenderer;
    private bool c73Pressed;
    private GameObject c83;
    private SpriteRenderer c83SpriteRenderer;
    private GameObject c93;
    private readonly RectInt c93Rect = new RectInt(550, 256, 50, 50);
    private SpriteRenderer c93SpriteRenderer;
    private bool c93Pressed;
    private GameObject ca3;
    private SpriteRenderer ca3SpriteRenderer;
    private GameObject c04;
    private SpriteRenderer c04SpriteRenderer;
    private GameObject c14;
    private SpriteRenderer c14SpriteRenderer;
    private GameObject c24;
    private SpriteRenderer c24SpriteRenderer;
    private GameObject c34;
    private SpriteRenderer c34SpriteRenderer;
    private GameObject c44;
    private SpriteRenderer c44SpriteRenderer;
    private GameObject c54;
    private SpriteRenderer c54SpriteRenderer;
    private GameObject c64;
    private SpriteRenderer c64SpriteRenderer;
    private GameObject c74;
    private SpriteRenderer c74SpriteRenderer;
    private GameObject c84;
    private SpriteRenderer c84SpriteRenderer;
    private GameObject c94;
    private SpriteRenderer c94SpriteRenderer;
    private GameObject ca4;
    private SpriteRenderer ca4SpriteRenderer;
    private GameObject c05;
    private SpriteRenderer c05SpriteRenderer;
    private GameObject c15;
    private readonly RectInt c15Rect = new RectInt(310, 316, 50, 50);
    private SpriteRenderer c15SpriteRenderer;
    private bool c15Pressed;
    private GameObject c25;
    private SpriteRenderer c25SpriteRenderer;
    private GameObject c35;
    private readonly RectInt c35Rect = new RectInt(370, 316, 50, 50);
    private SpriteRenderer c35SpriteRenderer;
    private bool c35Pressed;
    private GameObject c45;
    private SpriteRenderer c45SpriteRenderer;
    private GameObject c55;
    private readonly RectInt c55Rect = new RectInt(430, 316, 50, 50);
    private SpriteRenderer c55SpriteRenderer;
    private bool c55Pressed;
    private GameObject c65;
    private SpriteRenderer c65SpriteRenderer;
    private GameObject c75;
    private readonly RectInt c75Rect = new RectInt(490, 316, 50, 50);
    private SpriteRenderer c75SpriteRenderer;
    private bool c75Pressed;
    private GameObject c85;
    private SpriteRenderer c85SpriteRenderer;
    private GameObject c95;
    private readonly RectInt c95Rect = new RectInt(550, 316, 50, 50);
    private SpriteRenderer c95SpriteRenderer;
    private bool c95Pressed;
    private GameObject ca5;
    private SpriteRenderer ca5SpriteRenderer;
    private GameObject c06;
    private SpriteRenderer c06SpriteRenderer;
    private GameObject c16;
    private SpriteRenderer c16SpriteRenderer;
    private GameObject c26;
    private SpriteRenderer c26SpriteRenderer;
    private GameObject c36;
    private SpriteRenderer c36SpriteRenderer;
    private GameObject c46;
    private SpriteRenderer c46SpriteRenderer;
    private GameObject c56;
    private SpriteRenderer c56SpriteRenderer;
    private GameObject c66;
    private SpriteRenderer c66SpriteRenderer;
    private GameObject c76;
    private SpriteRenderer c76SpriteRenderer;
    private GameObject c86;
    private SpriteRenderer c86SpriteRenderer;
    private GameObject c96;
    private SpriteRenderer c96SpriteRenderer;
    private GameObject ca6;
    private SpriteRenderer ca6SpriteRenderer;
    private GameObject c07;
    private SpriteRenderer c07SpriteRenderer;
    private GameObject c17;
    private readonly RectInt c17Rect = new RectInt(310, 376, 50, 50);
    private SpriteRenderer c17SpriteRenderer;
    private bool c17Pressed;
    private GameObject c27;
    private SpriteRenderer c27SpriteRenderer;
    private GameObject c37;
    private readonly RectInt c37Rect = new RectInt(370, 376, 50, 50);
    private SpriteRenderer c37SpriteRenderer;
    private bool c37Pressed;
    private GameObject c47;
    private SpriteRenderer c47SpriteRenderer;
    private GameObject c57;
    private readonly RectInt c57Rect = new RectInt(430, 376, 50, 50);
    private SpriteRenderer c57SpriteRenderer;
    private bool c57Pressed;
    private GameObject c67;
    private SpriteRenderer c67SpriteRenderer;
    private GameObject c77;
    private readonly RectInt c77Rect = new RectInt(490, 376, 50, 50);
    private SpriteRenderer c77SpriteRenderer;
    private bool c77Pressed;
    private GameObject c87;
    private SpriteRenderer c87SpriteRenderer;
    private GameObject c97;
    private readonly RectInt c97Rect = new RectInt(550, 376, 50, 50);
    private SpriteRenderer c97SpriteRenderer;
    private bool c97Pressed;
    private GameObject ca7;
    private SpriteRenderer ca7SpriteRenderer;
    private GameObject c08;
    private SpriteRenderer c08SpriteRenderer;
    private GameObject c18;
    private SpriteRenderer c18SpriteRenderer;
    private GameObject c28;
    private SpriteRenderer c28SpriteRenderer;
    private GameObject c38;
    private SpriteRenderer c38SpriteRenderer;
    private GameObject c48;
    private SpriteRenderer c48SpriteRenderer;
    private GameObject c58;
    private SpriteRenderer c58SpriteRenderer;
    private GameObject c68;
    private SpriteRenderer c68SpriteRenderer;
    private GameObject c78;
    private SpriteRenderer c78SpriteRenderer;
    private GameObject c88;
    private SpriteRenderer c88SpriteRenderer;
    private GameObject c98;
    private SpriteRenderer c98SpriteRenderer;
    private GameObject ca8;
    private SpriteRenderer ca8SpriteRenderer;
    private GameObject c09;
    private SpriteRenderer c09SpriteRenderer;
    private GameObject c19;
    private readonly RectInt c19Rect = new RectInt(310, 436, 50, 50);
    private SpriteRenderer c19SpriteRenderer;
    private bool c19Pressed;
    private GameObject c29;
    private SpriteRenderer c29SpriteRenderer;
    private GameObject c39;
    private readonly RectInt c39Rect = new RectInt(370, 436, 50, 50);
    private SpriteRenderer c39SpriteRenderer;
    private bool c39Pressed;
    private GameObject c49;
    private SpriteRenderer c49SpriteRenderer;
    private GameObject c59;
    private readonly RectInt c59Rect = new RectInt(430, 436, 50, 50);
    private SpriteRenderer c59SpriteRenderer;
    private bool c59Pressed;
    private GameObject c69;
    private SpriteRenderer c69SpriteRenderer;
    private GameObject c79;
    private readonly RectInt c79Rect = new RectInt(490, 436, 50, 50);
    private SpriteRenderer c79SpriteRenderer;
    private bool c79Pressed;
    private GameObject c89;
    private SpriteRenderer c89SpriteRenderer;
    private GameObject c99;
    private readonly RectInt c99Rect = new RectInt(550, 436, 50, 50);
    private SpriteRenderer c99SpriteRenderer;
    private bool c99Pressed;
    private GameObject ca9;
    private SpriteRenderer ca9SpriteRenderer;
    private GameObject c0a;
    private SpriteRenderer c0aSpriteRenderer;
    private GameObject c1a;
    private SpriteRenderer c1aSpriteRenderer;
    private GameObject c2a;
    private SpriteRenderer c2aSpriteRenderer;
    private GameObject c3a;
    private SpriteRenderer c3aSpriteRenderer;
    private GameObject c4a;
    private SpriteRenderer c4aSpriteRenderer;
    private GameObject c5a;
    private SpriteRenderer c5aSpriteRenderer;
    private GameObject c6a;
    private SpriteRenderer c6aSpriteRenderer;
    private GameObject c7a;
    private SpriteRenderer c7aSpriteRenderer;
    private GameObject c8a;
    private SpriteRenderer c8aSpriteRenderer;
    private GameObject c9a;
    private SpriteRenderer c9aSpriteRenderer;
    private GameObject caa;
    private SpriteRenderer caaSpriteRenderer;
    private SimpleAnimation[] animations = new SimpleAnimation[25];
    #endregion
    #region Choices panel
    private GameObject chbox;
    private SpriteRenderer chboxSpriteRenderer;
    private GameObject ch1;
    private readonly RectInt ch1Rect = new RectInt(710, 281, 30, 30);
    private SpriteRenderer ch1SpriteRenderer;
    private bool ch1Pressed;
    private GameObject ch2;
    private readonly RectInt ch2Rect = new RectInt(740, 281, 30, 30);
    private SpriteRenderer ch2SpriteRenderer;
    private bool ch2Pressed;
    private GameObject ch3;
    private readonly RectInt ch3Rect = new RectInt(770, 281, 30, 30);
    private SpriteRenderer ch3SpriteRenderer;
    private bool ch3Pressed;
    private GameObject ch4;
    private readonly RectInt ch4Rect = new RectInt(800, 281, 30, 30);
    private SpriteRenderer ch4SpriteRenderer;
    private bool ch4Pressed;
    private GameObject ch5;
    private readonly RectInt ch5Rect = new RectInt(830, 281, 30, 30);
    private SpriteRenderer ch5SpriteRenderer;
    private bool ch5Pressed;
    private GameObject stbox;
    private SpriteRenderer stboxSpriteRenderer;
    private GameObject st1;
    private readonly RectInt st1Rect = new RectInt(710, 341, 30, 30);
    private SpriteRenderer st1SpriteRenderer;
    private bool st1Pressed;
    private GameObject st2;
    private readonly RectInt st2Rect = new RectInt(740, 341, 30, 30);
    private SpriteRenderer st2SpriteRenderer;
    private bool st2Pressed;
    private GameObject st3;
    private readonly RectInt st3Rect = new RectInt(770, 341, 30, 30);
    private SpriteRenderer st3SpriteRenderer;
    private bool st3Pressed;
    private GameObject st4;
    private readonly RectInt st4Rect = new RectInt(800, 341, 30, 30);
    private SpriteRenderer st4SpriteRenderer;
    private bool st4Pressed;
    private GameObject st5;
    private readonly RectInt st5Rect = new RectInt(830, 341, 30, 30);
    private SpriteRenderer st5SpriteRenderer;
    private bool st5Pressed;
    private GameObject spbox;
    private SpriteRenderer spboxSpriteRenderer;
    private GameObject sp1;
    private readonly RectInt sp1Rect = new RectInt(710, 401, 30, 30);
    private SpriteRenderer sp1SpriteRenderer;
    private bool sp1Pressed;
    private GameObject sp2;
    private readonly RectInt sp2Rect = new RectInt(740, 401, 30, 30);
    private SpriteRenderer sp2SpriteRenderer;
    private bool sp2Pressed;
    private GameObject sp3;
    private readonly RectInt sp3Rect = new RectInt(770, 401, 30, 30);
    private SpriteRenderer sp3SpriteRenderer;
    private bool sp3Pressed;
    private GameObject sp4;
    private readonly RectInt sp4Rect = new RectInt(800, 401, 30, 30);
    private SpriteRenderer sp4SpriteRenderer;
    private bool sp4Pressed;
    private GameObject sp5;
    private readonly RectInt sp5Rect = new RectInt(830, 401, 30, 30);
    private SpriteRenderer sp5SpriteRenderer;
    private bool sp5Pressed;
    #endregion
    private GameObject errbox;
    private SpriteRenderer errboxSpriteRenderer;
    private GameObject msgbox;
    private SpriteRenderer msgboxSpriteRenderer;

    private void Awake()
    {
        SpriteRenderer spriteRenderer;

        isSplashEnabled = false;

        music = new GameObject("music");
        musicAudioSource = music.AddComponent<AudioSource>();
        musicAudioSource.clip = Resources.Load<AudioClip>("Audio/music");
        musicAudioSource.playOnAwake = false;
        musicAudioSource.loop = true;

        splogo = new GameObject("splogo");
        splogo.layer = 5;
        spriteRenderer = splogo.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("Images/splogo");
        splogoLineRenderer = splogo.AddComponent<LineRenderer>();
        splogoLineRenderer.loop = true;
        splogoLineRenderer.positionCount = 4;
        splogoLineRenderer.startColor = Color.black;
        splogoLineRenderer.endColor = Color.black;
        splogoLineRenderer.material = Resources.Load<Material>("Materials/Line");
        splogoPressed = false;

        EnableUi();
    }

    // Start is called before the first frame update
    private void Start()
    {
        nextfloor();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (IsMousePositionInWorkAreaRect(Input.mousePosition, splogoRect))
            {
                splogoLineRenderer.startColor = Color.red;
                splogoLineRenderer.endColor = Color.red;
                splogoPressed = true;
            }
            else if (isUiEnabled)
            {
                if (IsMousePositionInWorkAreaRect(Input.mousePosition, musicboxRect))
                {
                    musicboxPressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c11Rect))
                {
                    c11Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c31Rect))
                {
                    c31Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c51Rect))
                {
                    c51Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c71Rect))
                {
                    c71Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c91Rect))
                {
                    c91Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c13Rect))
                {
                    c13Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c33Rect))
                {
                    c33Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c53Rect))
                {
                    c53Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c73Rect))
                {
                    c73Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c93Rect))
                {
                    c93Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c15Rect))
                {
                    c15Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c35Rect))
                {
                    c35Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c55Rect))
                {
                    c55Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c75Rect))
                {
                    c75Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c95Rect))
                {
                    c95Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c17Rect))
                {
                    c17Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c37Rect))
                {
                    c37Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c57Rect))
                {
                    c57Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c77Rect))
                {
                    c77Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c97Rect))
                {
                    c97Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c19Rect))
                {
                    c19Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c39Rect))
                {
                    c39Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c59Rect))
                {
                    c59Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c79Rect))
                {
                    c79Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, c99Rect))
                {
                    c99Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch1Rect))
                {
                    ch1Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch2Rect))
                {
                    ch2Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch3Rect))
                {
                    ch3Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch4Rect))
                {
                    ch4Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch5Rect))
                {
                    ch5Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, st1Rect))
                {
                    st1Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, st2Rect))
                {
                    st2Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, st3Rect))
                {
                    st3Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, st4Rect))
                {
                    st4Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, st5Rect))
                {
                    st5Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp1Rect))
                {
                    sp1Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp2Rect))
                {
                    sp2Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp3Rect))
                {
                    sp3Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp4Rect))
                {
                    sp4Pressed = true;
                }
                else if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp5Rect))
                {
                    sp5Pressed = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            splogoLineRenderer.startColor = Color.black;
            splogoLineRenderer.endColor = Color.black;

            if (splogoPressed)
            {
                if (IsMousePositionInWorkAreaRect(Input.mousePosition, splogoRect))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
            else if (isUiEnabled)
            {
                if (musicboxPressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, musicboxRect))
                    {
                        musicbox_OnClick();
                    }
                }
                else if (c11Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c11Rect))
                    {
                        c11_OnClick();
                    }
                }
                else if (c31Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c31Rect))
                    {
                        c31_OnClick();
                    }
                }
                else if (c51Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c51Rect))
                    {
                        c51_OnClick();
                    }
                }
                else if (c71Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c71Rect))
                    {
                        c71_OnClick();
                    }
                }
                else if (c91Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c91Rect))
                    {
                        c91_OnClick();
                    }
                }
                else if (c13Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c13Rect))
                    {
                        c13_OnClick();
                    }
                }
                else if (c33Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c33Rect))
                    {
                        c33_OnClick();
                    }
                }
                else if (c53Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c53Rect))
                    {
                        c53_OnClick();
                    }
                }
                else if (c73Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c73Rect))
                    {
                        c73_OnClick();
                    }
                }
                else if (c93Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c93Rect))
                    {
                        c93_OnClick();
                    }
                }
                else if (c15Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c15Rect))
                    {
                        c15_OnClick();
                    }
                }
                else if (c35Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c35Rect))
                    {
                        c35_OnClick();
                    }
                }
                else if (c55Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c55Rect))
                    {
                        c55_OnClick();
                    }
                }
                else if (c75Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c75Rect))
                    {
                        c75_OnClick();
                    }
                }
                else if (c95Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c95Rect))
                    {
                        c95_OnClick();
                    }
                }
                else if (c17Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c17Rect))
                    {
                        c17_OnClick();
                    }
                }
                else if (c37Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c37Rect))
                    {
                        c37_OnClick();
                    }
                }
                else if (c57Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c57Rect))
                    {
                        c57_OnClick();
                    }
                }
                else if (c77Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c77Rect))
                    {
                        c77_OnClick();
                    }
                }
                else if (c97Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c97Rect))
                    {
                        c97_OnClick();
                    }
                }
                else if (c19Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c19Rect))
                    {
                        c19_OnClick();
                    }
                }
                else if (c39Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c39Rect))
                    {
                        c39_OnClick();
                    }
                }
                else if (c59Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c59Rect))
                    {
                        c59_OnClick();
                    }
                }
                else if (c79Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c79Rect))
                    {
                        c79_OnClick();
                    }
                }
                else if (c99Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, c99Rect))
                    {
                        c99_OnClick();
                    }
                }
                else if (ch1Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch1Rect))
                    {
                        ch1_OnClick();
                    }
                }
                else if (ch2Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch2Rect))
                    {
                        ch2_OnClick();
                    }
                }
                else if (ch3Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch3Rect))
                    {
                        ch3_OnClick();
                    }
                }
                else if (ch4Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch4Rect))
                    {
                        ch4_OnClick();
                    }
                }
                else if (ch5Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, ch5Rect))
                    {
                        ch5_OnClick();
                    }
                }
                else if (st1Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, st1Rect))
                    {
                        st1_OnClick();
                    }
                }
                else if (st2Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, st2Rect))
                    {
                        st2_OnClick();
                    }
                }
                else if (st3Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, st3Rect))
                    {
                        st3_OnClick();
                    }
                }
                else if (st4Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, st4Rect))
                    {
                        st4_OnClick();
                    }
                }
                else if (st5Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, st5Rect))
                    {
                        st5_OnClick();
                    }
                }
                else if (sp1Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp1Rect))
                    {
                        sp1_OnClick();
                    }
                }
                else if (sp2Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp2Rect))
                    {
                        sp2_OnClick();
                    }
                }
                else if (sp3Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp3Rect))
                    {
                        sp3_OnClick();
                    }
                }
                else if (sp4Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp4Rect))
                    {
                        sp4_OnClick();
                    }
                }
                else if (sp5Pressed)
                {
                    if (IsMousePositionInWorkAreaRect(Input.mousePosition, sp5Rect))
                    {
                        sp5_OnClick();
                    }
                }
            }

            splogoPressed = false;
            musicboxPressed = false;
            c11Pressed = false;
            c31Pressed = false;
            c51Pressed = false;
            c71Pressed = false;
            c91Pressed = false;
            c13Pressed = false;
            c33Pressed = false;
            c53Pressed = false;
            c73Pressed = false;
            c93Pressed = false;
            c15Pressed = false;
            c35Pressed = false;
            c55Pressed = false;
            c75Pressed = false;
            c95Pressed = false;
            c17Pressed = false;
            c37Pressed = false;
            c57Pressed = false;
            c77Pressed = false;
            c97Pressed = false;
            c19Pressed = false;
            c39Pressed = false;
            c59Pressed = false;
            c79Pressed = false;
            c99Pressed = false;
            ch1Pressed = false;
            ch2Pressed = false;
            ch3Pressed = false;
            ch4Pressed = false;
            ch5Pressed = false;
            st1Pressed = false;
            st2Pressed = false;
            st3Pressed = false;
            st4Pressed = false;
            st5Pressed = false;
            sp1Pressed = false;
            sp2Pressed = false;
            sp3Pressed = false;
            sp4Pressed = false;
            sp5Pressed = false;
        }

        UpdateSprites();
    }

    private void musicbox_OnClick()
    {
        if (!musicAudioSource.isPlaying)
        {
            startmusic();
        }
        else
        {
            stopmusic();
        }
    }

    private void c11_OnClick()
    {
        pick(1, 1);
    }

    private void c31_OnClick()
    {
        pick(3, 1);
    }

    private void c51_OnClick()
    {
        pick(5, 1);
    }

    private void c71_OnClick()
    {
        pick(7, 1);
    }

    private void c91_OnClick()
    {
        pick(9, 1);
    }

    private void c13_OnClick()
    {
        pick(1, 3);
    }

    private void c33_OnClick()
    {
        pick(3, 3);
    }

    private void c53_OnClick()
    {
        pick(5, 3);
    }

    private void c73_OnClick()
    {
        pick(7, 3);
    }

    private void c93_OnClick()
    {
        pick(9, 3);
    }

    private void c15_OnClick()
    {
        pick(1, 5);
    }

    private void c35_OnClick()
    {
        pick(3, 5);
    }

    private void c55_OnClick()
    {
        pick(5, 5);
    }

    private void c75_OnClick()
    {
        pick(7, 5);
    }

    private void c95_OnClick()
    {
        pick(9, 5);
    }

    private void c17_OnClick()
    {
        pick(1, 7);
    }

    private void c37_OnClick()
    {
        pick(3, 7);
    }

    private void c57_OnClick()
    {
        pick(5, 7);
    }

    private void c77_OnClick()
    {
        pick(7, 7);
    }

    private void c97_OnClick()
    {
        pick(9, 7);
    }

    private void c19_OnClick()
    {
        pick(1, 9);
    }

    private void c39_OnClick()
    {
        pick(3, 9);
    }

    private void c59_OnClick()
    {
        pick(5, 9);
    }

    private void c79_OnClick()
    {
        pick(7, 9);
    }

    private void c99_OnClick()
    {
        pick(9, 9);
    }

    private void ch1_OnClick()
    {
        chose(0, 1);
    }

    private void ch2_OnClick()
    {
        chose(0, 2);
    }

    private void ch3_OnClick()
    {
        chose(0, 3);
    }

    private void ch4_OnClick()
    {
        chose(0, 4);
    }

    private void ch5_OnClick()
    {
        chose(0, 5);
    }

    private void st1_OnClick()
    {
        chose(1, 1);
    }

    private void st2_OnClick()
    {
        chose(1, 2);
    }

    private void st3_OnClick()
    {
        chose(1, 3);
    }

    private void st4_OnClick()
    {
        chose(1, 4);
    }

    private void st5_OnClick()
    {
        chose(1, 5);
    }

    private void sp1_OnClick()
    {
        chose(2, 1);
    }

    private void sp2_OnClick()
    {
        chose(2, 2);
    }

    private void sp3_OnClick()
    {
        chose(2, 3);
    }

    private void sp4_OnClick()
    {
        chose(2, 4);
    }

    private void sp5_OnClick()
    {
        chose(2, 5);
    }

    private bool IsMousePositionInWorkAreaRect(Vector3 mousePosition, RectInt workAreaRect)
    {
        Vector2 minPosition = GetWorkAreaPosition(workAreaRect.xMin, workAreaRect.yMin);
        Vector2 maxPosition = GetWorkAreaPosition(workAreaRect.xMin + workAreaRect.width, workAreaRect.yMin + workAreaRect.height);
        float x = (mousePosition.x * 2.0F - Screen.width) / Screen.height;
        float y = mousePosition.y * 2.0F / Screen.height - 1.0F;
        return x >= minPosition.x && x < maxPosition.x && y <= minPosition.y && y > maxPosition.y;
    }

    private void CalculateWorkArea()
    {
        if ((float)Screen.width / Screen.height >= (interfaceWidth + 16.0F) / interfaceHeight)
        {
            workArea.x = -(interfaceWidth / interfaceHeight);
            workArea.y = 1.0F;
            workArea.width = -workArea.x * 2.0F;
            workArea.height = 2.0F;
        }
        else
        {
            float ratio = (float)Screen.width / Screen.height;
            workArea.x = -ratio * interfaceWidth / (interfaceWidth + 16.0F);
            workArea.y = -workArea.x * interfaceHeight / interfaceWidth;
            workArea.width = -workArea.x * 2.0F;
            workArea.height = workArea.y * 2.0F;
        }
        pixelsPerUnit = interfaceHeight / workArea.height;
    }

    private void EnableSplash(Sprite sprite1, Sprite sprite2, Sprite sprite3)
    {
        SpriteRenderer spriteRenderer;

        isSplashEnabled = true;

        gameover1 = new GameObject("gameover1");
        gameover1.layer = 5;
        spriteRenderer = gameover1.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;

        gameover2 = new GameObject("gameover2");
        gameover2.layer = 5;
        spriteRenderer = gameover2.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite2;

        gameover3 = new GameObject("gameover3");
        gameover3.layer = 5;
        spriteRenderer = gameover3.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite3;
    }

    private void EnableUi()
    {
        SpriteRenderer spriteRenderer;

        isUiEnabled = true;

        musicbox = new GameObject("musicbox");
        musicbox.layer = 5;
        musicboxSpriteRenderer = musicbox.AddComponent<SpriteRenderer>();
        musicboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        musicboxSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        musicboxSpriteRenderer.size = new Vector2(25.0F, 3.0F);
        musicboxPressed = false;

        floorbox = new GameObject("floorbox");
        floorbox.layer = 5;
        floorboxSpriteRenderer = floorbox.AddComponent<SpriteRenderer>();
        floorboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/start");
        floorboxSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        floorboxSpriteRenderer.size = new Vector2(50.0F, 3.0F);

        labelf = new GameObject("labelf");
        labelf.layer = 5;
        spriteRenderer = labelf.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("Images/labelf");

        fnum = new GameObject("fnum");
        fnum.layer = 5;
        fnumSpriteRenderer = fnum.AddComponent<SpriteRenderer>();
        fnumSpriteRenderer.sprite = Resources.Load<Sprite>("Images/label10");

        #region Levels panel
        level = new GameObject("level");
        level.layer = 5;
        spriteRenderer = level.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("Images/level");

        charm = new GameObject("charm");
        charm.layer = 5;
        spriteRenderer = charm.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("Images/charm");

        chlev = new GameObject("chlev");
        chlev.layer = 5;
        chlevSpriteRenderer = chlev.AddComponent<SpriteRenderer>();
        chlevSpriteRenderer.sprite = Resources.Load<Sprite>("Images/label10");

        chb1 = new GameObject("chb1");
        chb1.layer = 5;
        chb1SpriteRenderer = chb1.AddComponent<SpriteRenderer>();
        chb1SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb1SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb1SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb2 = new GameObject("chb2");
        chb2.layer = 5;
        chb2SpriteRenderer = chb2.AddComponent<SpriteRenderer>();
        chb2SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb2SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb2SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb3 = new GameObject("chb3");
        chb3.layer = 5;
        chb3SpriteRenderer = chb3.AddComponent<SpriteRenderer>();
        chb3SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb3SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb3SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb4 = new GameObject("chb4");
        chb4.layer = 5;
        chb4SpriteRenderer = chb4.AddComponent<SpriteRenderer>();
        chb4SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb4SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb4SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb5 = new GameObject("chb5");
        chb5.layer = 5;
        chb5SpriteRenderer = chb5.AddComponent<SpriteRenderer>();
        chb5SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb5SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb5SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb6 = new GameObject("chb6");
        chb6.layer = 5;
        chb6SpriteRenderer = chb6.AddComponent<SpriteRenderer>();
        chb6SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb6SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb6SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb7 = new GameObject("chb7");
        chb7.layer = 5;
        chb7SpriteRenderer = chb7.AddComponent<SpriteRenderer>();
        chb7SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb7SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb7SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb8 = new GameObject("chb8");
        chb8.layer = 5;
        chb8SpriteRenderer = chb8.AddComponent<SpriteRenderer>();
        chb8SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb8SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb8SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb9 = new GameObject("chb9");
        chb9.layer = 5;
        chb9SpriteRenderer = chb9.AddComponent<SpriteRenderer>();
        chb9SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb9SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb9SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        chb10 = new GameObject("chb10");
        chb10.layer = 5;
        chb10SpriteRenderer = chb10.AddComponent<SpriteRenderer>();
        chb10SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        chb10SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chb10SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stealth = new GameObject("stealth");
        stealth.layer = 5;
        spriteRenderer = stealth.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("Images/stealth");

        stlev = new GameObject("stlev");
        stlev.layer = 5;
        stlevSpriteRenderer = stlev.AddComponent<SpriteRenderer>();
        stlevSpriteRenderer.sprite = Resources.Load<Sprite>("Images/label10");

        stb1 = new GameObject("stb1");
        stb1.layer = 5;
        stb1SpriteRenderer = stb1.AddComponent<SpriteRenderer>();
        stb1SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb1SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb1SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb2 = new GameObject("stb2");
        stb2.layer = 5;
        stb2SpriteRenderer = stb2.AddComponent<SpriteRenderer>();
        stb2SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb2SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb2SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb3 = new GameObject("stb3");
        stb3.layer = 5;
        stb3SpriteRenderer = stb3.AddComponent<SpriteRenderer>();
        stb3SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb3SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb3SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb4 = new GameObject("stb4");
        stb4.layer = 5;
        stb4SpriteRenderer = stb4.AddComponent<SpriteRenderer>();
        stb4SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb4SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb4SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb5 = new GameObject("stb5");
        stb5.layer = 5;
        stb5SpriteRenderer = stb5.AddComponent<SpriteRenderer>();
        stb5SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb5SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb5SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb6 = new GameObject("stb6");
        stb6.layer = 5;
        stb6SpriteRenderer = stb6.AddComponent<SpriteRenderer>();
        stb6SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb6SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb6SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb7 = new GameObject("stb7");
        stb7.layer = 5;
        stb7SpriteRenderer = stb7.AddComponent<SpriteRenderer>();
        stb7SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb7SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb7SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb8 = new GameObject("stb8");
        stb8.layer = 5;
        stb8SpriteRenderer = stb8.AddComponent<SpriteRenderer>();
        stb8SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb8SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb8SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb9 = new GameObject("stb9");
        stb9.layer = 5;
        stb9SpriteRenderer = stb9.AddComponent<SpriteRenderer>();
        stb9SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb9SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb9SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        stb10 = new GameObject("stb10");
        stb10.layer = 5;
        stb10SpriteRenderer = stb10.AddComponent<SpriteRenderer>();
        stb10SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        stb10SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stb10SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spnknss = new GameObject("spnknss");
        spnknss.layer = 5;
        spriteRenderer = spnknss.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("Images/spnknss");

        splev = new GameObject("splev");
        splev.layer = 5;
        splevSpriteRenderer = splev.AddComponent<SpriteRenderer>();
        splevSpriteRenderer.sprite = Resources.Load<Sprite>("Images/label10");

        spb1 = new GameObject("spb1");
        spb1.layer = 5;
        spb1SpriteRenderer = spb1.AddComponent<SpriteRenderer>();
        spb1SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb1SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb1SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb2 = new GameObject("spb2");
        spb2.layer = 5;
        spb2SpriteRenderer = spb2.AddComponent<SpriteRenderer>();
        spb2SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb2SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb2SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb3 = new GameObject("spb3");
        spb3.layer = 5;
        spb3SpriteRenderer = spb3.AddComponent<SpriteRenderer>();
        spb3SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb3SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb3SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb4 = new GameObject("spb4");
        spb4.layer = 5;
        spb4SpriteRenderer = spb4.AddComponent<SpriteRenderer>();
        spb4SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb4SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb4SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb5 = new GameObject("spb5");
        spb5.layer = 5;
        spb5SpriteRenderer = spb5.AddComponent<SpriteRenderer>();
        spb5SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb5SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb5SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb6 = new GameObject("spb6");
        spb6.layer = 5;
        spb6SpriteRenderer = spb6.AddComponent<SpriteRenderer>();
        spb6SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb6SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb6SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb7 = new GameObject("spb7");
        spb7.layer = 5;
        spb7SpriteRenderer = spb7.AddComponent<SpriteRenderer>();
        spb7SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb7SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb7SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb8 = new GameObject("spb8");
        spb8.layer = 5;
        spb8SpriteRenderer = spb8.AddComponent<SpriteRenderer>();
        spb8SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb8SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb8SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb9 = new GameObject("spb9");
        spb9.layer = 5;
        spb9SpriteRenderer = spb9.AddComponent<SpriteRenderer>();
        spb9SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb9SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb9SpriteRenderer.size = new Vector2(1.5F, 3.0F);

        spb10 = new GameObject("spb10");
        spb10.layer = 5;
        spb10SpriteRenderer = spb10.AddComponent<SpriteRenderer>();
        spb10SpriteRenderer.sprite = Resources.Load<Sprite>("Images/green");
        spb10SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spb10SpriteRenderer.size = new Vector2(1.5F, 3.0F);
        #endregion

        #region Map panel
        c00 = new GameObject("c00");
        c00.layer = 5;
        c00SpriteRenderer = c00.AddComponent<SpriteRenderer>();
        c00SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c00SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c00SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c10 = new GameObject("c10");
        c10.layer = 5;
        c10SpriteRenderer = c10.AddComponent<SpriteRenderer>();
        c10SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c10SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c10SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c20 = new GameObject("c20");
        c20.layer = 5;
        c20SpriteRenderer = c20.AddComponent<SpriteRenderer>();
        c20SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c20SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c20SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c30 = new GameObject("c30");
        c30.layer = 5;
        c30SpriteRenderer = c30.AddComponent<SpriteRenderer>();
        c30SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c30SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c30SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c40 = new GameObject("c40");
        c40.layer = 5;
        c40SpriteRenderer = c40.AddComponent<SpriteRenderer>();
        c40SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c40SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c40SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c50 = new GameObject("c50");
        c50.layer = 5;
        c50SpriteRenderer = c50.AddComponent<SpriteRenderer>();
        c50SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c50SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c50SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c60 = new GameObject("c60");
        c60.layer = 5;
        c60SpriteRenderer = c60.AddComponent<SpriteRenderer>();
        c60SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c60SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c60SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c70 = new GameObject("c70");
        c70.layer = 5;
        c70SpriteRenderer = c70.AddComponent<SpriteRenderer>();
        c70SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c70SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c70SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c80 = new GameObject("c80");
        c80.layer = 5;
        c80SpriteRenderer = c80.AddComponent<SpriteRenderer>();
        c80SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c80SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c80SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c90 = new GameObject("c90");
        c90.layer = 5;
        c90SpriteRenderer = c90.AddComponent<SpriteRenderer>();
        c90SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c90SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c90SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        ca0 = new GameObject("ca0");
        ca0.layer = 5;
        ca0SpriteRenderer = ca0.AddComponent<SpriteRenderer>();
        ca0SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca0SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca0SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c01 = new GameObject("c01");
        c01.layer = 5;
        c01SpriteRenderer = c01.AddComponent<SpriteRenderer>();
        c01SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c01SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c01SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c11 = new GameObject("c11");
        c11.layer = 5;
        c11SpriteRenderer = c11.AddComponent<SpriteRenderer>();
        c11SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c11SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c11SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c11Pressed = false;
        animations[0].spriteRenderer = c11SpriteRenderer;

        c21 = new GameObject("c21");
        c21.layer = 5;
        c21SpriteRenderer = c21.AddComponent<SpriteRenderer>();
        c21SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c21SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c21SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c31 = new GameObject("c31");
        c31.layer = 5;
        c31SpriteRenderer = c31.AddComponent<SpriteRenderer>();
        c31SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c31SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c31SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c31Pressed = false;
        animations[1].spriteRenderer = c31SpriteRenderer;

        c41 = new GameObject("c41");
        c41.layer = 5;
        c41SpriteRenderer = c41.AddComponent<SpriteRenderer>();
        c41SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c41SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c41SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c51 = new GameObject("c51");
        c51.layer = 5;
        c51SpriteRenderer = c51.AddComponent<SpriteRenderer>();
        c51SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c51SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c51SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c51Pressed = false;
        animations[2].spriteRenderer = c51SpriteRenderer;

        c61 = new GameObject("c61");
        c61.layer = 5;
        c61SpriteRenderer = c61.AddComponent<SpriteRenderer>();
        c61SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c61SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c61SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c71 = new GameObject("c71");
        c71.layer = 5;
        c71SpriteRenderer = c71.AddComponent<SpriteRenderer>();
        c71SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c71SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c71SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c71Pressed = false;
        animations[3].spriteRenderer = c71SpriteRenderer;

        c81 = new GameObject("c81");
        c81.layer = 5;
        c81SpriteRenderer = c81.AddComponent<SpriteRenderer>();
        c81SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c81SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c81SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c91 = new GameObject("c91");
        c91.layer = 5;
        c91SpriteRenderer = c91.AddComponent<SpriteRenderer>();
        c91SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c91SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c91SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c91Pressed = false;
        animations[4].spriteRenderer = c91SpriteRenderer;

        ca1 = new GameObject("ca1");
        ca1.layer = 5;
        ca1SpriteRenderer = ca1.AddComponent<SpriteRenderer>();
        ca1SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca1SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca1SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c02 = new GameObject("c02");
        c02.layer = 5;
        c02SpriteRenderer = c02.AddComponent<SpriteRenderer>();
        c02SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c02SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c02SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c12 = new GameObject("c12");
        c12.layer = 5;
        c12SpriteRenderer = c12.AddComponent<SpriteRenderer>();
        c12SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c12SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c12SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c22 = new GameObject("c22");
        c22.layer = 5;
        c22SpriteRenderer = c22.AddComponent<SpriteRenderer>();
        c22SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c22SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c22SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c32 = new GameObject("c32");
        c32.layer = 5;
        c32SpriteRenderer = c32.AddComponent<SpriteRenderer>();
        c32SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c32SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c32SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c42 = new GameObject("c42");
        c42.layer = 5;
        c42SpriteRenderer = c42.AddComponent<SpriteRenderer>();
        c42SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c42SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c42SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c52 = new GameObject("c52");
        c52.layer = 5;
        c52SpriteRenderer = c52.AddComponent<SpriteRenderer>();
        c52SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c52SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c52SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c62 = new GameObject("c62");
        c62.layer = 5;
        c62SpriteRenderer = c62.AddComponent<SpriteRenderer>();
        c62SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c62SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c62SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c72 = new GameObject("c72");
        c72.layer = 5;
        c72SpriteRenderer = c72.AddComponent<SpriteRenderer>();
        c72SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c72SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c72SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c82 = new GameObject("c82");
        c82.layer = 5;
        c82SpriteRenderer = c82.AddComponent<SpriteRenderer>();
        c82SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c82SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c82SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c92 = new GameObject("c92");
        c92.layer = 5;
        c92SpriteRenderer = c92.AddComponent<SpriteRenderer>();
        c92SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c92SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c92SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        ca2 = new GameObject("ca2");
        ca2.layer = 5;
        ca2SpriteRenderer = ca2.AddComponent<SpriteRenderer>();
        ca2SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca2SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca2SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c03 = new GameObject("c03");
        c03.layer = 5;
        c03SpriteRenderer = c03.AddComponent<SpriteRenderer>();
        c03SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c03SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c03SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c13 = new GameObject("c13");
        c13.layer = 5;
        c13SpriteRenderer = c13.AddComponent<SpriteRenderer>();
        c13SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c13SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c13SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c13Pressed = false;
        animations[5].spriteRenderer = c13SpriteRenderer;

        c23 = new GameObject("c23");
        c23.layer = 5;
        c23SpriteRenderer = c23.AddComponent<SpriteRenderer>();
        c23SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c23SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c23SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c33 = new GameObject("c33");
        c33.layer = 5;
        c33SpriteRenderer = c33.AddComponent<SpriteRenderer>();
        c33SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c33SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c33SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c33Pressed = false;
        animations[6].spriteRenderer = c33SpriteRenderer;

        c43 = new GameObject("c43");
        c43.layer = 5;
        c43SpriteRenderer = c43.AddComponent<SpriteRenderer>();
        c43SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c43SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c43SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c53 = new GameObject("c53");
        c53.layer = 5;
        c53SpriteRenderer = c53.AddComponent<SpriteRenderer>();
        c53SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c53SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c53SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c53Pressed = false;
        animations[7].spriteRenderer = c53SpriteRenderer;

        c63 = new GameObject("c63");
        c63.layer = 5;
        c63SpriteRenderer = c63.AddComponent<SpriteRenderer>();
        c63SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c63SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c63SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c73 = new GameObject("c73");
        c73.layer = 5;
        c73SpriteRenderer = c73.AddComponent<SpriteRenderer>();
        c73SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c73SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c73SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c73Pressed = false;
        animations[8].spriteRenderer = c73SpriteRenderer;

        c83 = new GameObject("c83");
        c83.layer = 5;
        c83SpriteRenderer = c83.AddComponent<SpriteRenderer>();
        c83SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c83SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c83SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c93 = new GameObject("c93");
        c93.layer = 5;
        c93SpriteRenderer = c93.AddComponent<SpriteRenderer>();
        c93SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c93SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c93SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c93Pressed = false;
        animations[9].spriteRenderer = c93SpriteRenderer;

        ca3 = new GameObject("ca3");
        ca3.layer = 5;
        ca3SpriteRenderer = ca3.AddComponent<SpriteRenderer>();
        ca3SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca3SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca3SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c04 = new GameObject("c04");
        c04.layer = 5;
        c04SpriteRenderer = c04.AddComponent<SpriteRenderer>();
        c04SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c04SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c04SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c14 = new GameObject("c14");
        c14.layer = 5;
        c14SpriteRenderer = c14.AddComponent<SpriteRenderer>();
        c14SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c14SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c14SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c24 = new GameObject("c24");
        c24.layer = 5;
        c24SpriteRenderer = c24.AddComponent<SpriteRenderer>();
        c24SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c24SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c24SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c34 = new GameObject("c34");
        c34.layer = 5;
        c34SpriteRenderer = c34.AddComponent<SpriteRenderer>();
        c34SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c34SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c34SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c44 = new GameObject("c44");
        c44.layer = 5;
        c44SpriteRenderer = c44.AddComponent<SpriteRenderer>();
        c44SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c44SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c44SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c54 = new GameObject("c54");
        c54.layer = 5;
        c54SpriteRenderer = c54.AddComponent<SpriteRenderer>();
        c54SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c54SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c54SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c64 = new GameObject("c64");
        c64.layer = 5;
        c64SpriteRenderer = c64.AddComponent<SpriteRenderer>();
        c64SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c64SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c64SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c74 = new GameObject("c74");
        c74.layer = 5;
        c74SpriteRenderer = c74.AddComponent<SpriteRenderer>();
        c74SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c74SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c74SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c84 = new GameObject("c84");
        c84.layer = 5;
        c84SpriteRenderer = c84.AddComponent<SpriteRenderer>();
        c84SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c84SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c84SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c94 = new GameObject("c94");
        c94.layer = 5;
        c94SpriteRenderer = c94.AddComponent<SpriteRenderer>();
        c94SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c94SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c94SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        ca4 = new GameObject("ca4");
        ca4.layer = 5;
        ca4SpriteRenderer = ca4.AddComponent<SpriteRenderer>();
        ca4SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca4SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca4SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c05 = new GameObject("c05");
        c05.layer = 5;
        c05SpriteRenderer = c05.AddComponent<SpriteRenderer>();
        c05SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c05SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c05SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c15 = new GameObject("c15");
        c15.layer = 5;
        c15SpriteRenderer = c15.AddComponent<SpriteRenderer>();
        c15SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c15SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c15SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c15Pressed = false;
        animations[10].spriteRenderer = c15SpriteRenderer;

        c25 = new GameObject("c25");
        c25.layer = 5;
        c25SpriteRenderer = c25.AddComponent<SpriteRenderer>();
        c25SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c25SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c25SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c35 = new GameObject("c35");
        c35.layer = 5;
        c35SpriteRenderer = c35.AddComponent<SpriteRenderer>();
        c35SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c35SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c35SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c35Pressed = false;
        animations[11].spriteRenderer = c35SpriteRenderer;

        c45 = new GameObject("c45");
        c45.layer = 5;
        c45SpriteRenderer = c45.AddComponent<SpriteRenderer>();
        c45SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c45SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c45SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c55 = new GameObject("c55");
        c55.layer = 5;
        c55SpriteRenderer = c55.AddComponent<SpriteRenderer>();
        c55SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c55SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c55SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c55Pressed = false;
        animations[12].spriteRenderer = c55SpriteRenderer;

        c65 = new GameObject("c65");
        c65.layer = 5;
        c65SpriteRenderer = c65.AddComponent<SpriteRenderer>();
        c65SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c65SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c65SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c75 = new GameObject("c75");
        c75.layer = 5;
        c75SpriteRenderer = c75.AddComponent<SpriteRenderer>();
        c75SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c75SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c75SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c75Pressed = false;
        animations[13].spriteRenderer = c75SpriteRenderer;

        c85 = new GameObject("c85");
        c85.layer = 5;
        c85SpriteRenderer = c85.AddComponent<SpriteRenderer>();
        c85SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c85SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c85SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c95 = new GameObject("c95");
        c95.layer = 5;
        c95SpriteRenderer = c95.AddComponent<SpriteRenderer>();
        c95SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c95SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c95SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c95Pressed = false;
        animations[14].spriteRenderer = c95SpriteRenderer;

        ca5 = new GameObject("ca5");
        ca5.layer = 5;
        ca5SpriteRenderer = ca5.AddComponent<SpriteRenderer>();
        ca5SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca5SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca5SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c06 = new GameObject("c06");
        c06.layer = 5;
        c06SpriteRenderer = c06.AddComponent<SpriteRenderer>();
        c06SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c06SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c06SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c16 = new GameObject("c16");
        c16.layer = 5;
        c16SpriteRenderer = c16.AddComponent<SpriteRenderer>();
        c16SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c16SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c16SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c26 = new GameObject("c26");
        c26.layer = 5;
        c26SpriteRenderer = c26.AddComponent<SpriteRenderer>();
        c26SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c26SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c26SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c36 = new GameObject("c36");
        c36.layer = 5;
        c36SpriteRenderer = c36.AddComponent<SpriteRenderer>();
        c36SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c36SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c36SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c46 = new GameObject("c46");
        c46.layer = 5;
        c46SpriteRenderer = c46.AddComponent<SpriteRenderer>();
        c46SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c46SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c46SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c56 = new GameObject("c56");
        c56.layer = 5;
        c56SpriteRenderer = c56.AddComponent<SpriteRenderer>();
        c56SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c56SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c56SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c66 = new GameObject("c66");
        c66.layer = 5;
        c66SpriteRenderer = c66.AddComponent<SpriteRenderer>();
        c66SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c66SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c66SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c76 = new GameObject("c76");
        c76.layer = 5;
        c76SpriteRenderer = c76.AddComponent<SpriteRenderer>();
        c76SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c76SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c76SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c86 = new GameObject("c86");
        c86.layer = 5;
        c86SpriteRenderer = c86.AddComponent<SpriteRenderer>();
        c86SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c86SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c86SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c96 = new GameObject("c96");
        c96.layer = 5;
        c96SpriteRenderer = c96.AddComponent<SpriteRenderer>();
        c96SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c96SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c96SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        ca6 = new GameObject("ca6");
        ca6.layer = 5;
        ca6SpriteRenderer = ca6.AddComponent<SpriteRenderer>();
        ca6SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca6SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca6SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c07 = new GameObject("c07");
        c07.layer = 5;
        c07SpriteRenderer = c07.AddComponent<SpriteRenderer>();
        c07SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c07SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c07SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c17 = new GameObject("c17");
        c17.layer = 5;
        c17SpriteRenderer = c17.AddComponent<SpriteRenderer>();
        c17SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c17SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c17SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c17Pressed = false;
        animations[15].spriteRenderer = c17SpriteRenderer;

        c27 = new GameObject("c27");
        c27.layer = 5;
        c27SpriteRenderer = c27.AddComponent<SpriteRenderer>();
        c27SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c27SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c27SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c37 = new GameObject("c37");
        c37.layer = 5;
        c37SpriteRenderer = c37.AddComponent<SpriteRenderer>();
        c37SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c37SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c37SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c37Pressed = false;
        animations[16].spriteRenderer = c37SpriteRenderer;

        c47 = new GameObject("c47");
        c47.layer = 5;
        c47SpriteRenderer = c47.AddComponent<SpriteRenderer>();
        c47SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c47SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c47SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c57 = new GameObject("c57");
        c57.layer = 5;
        c57SpriteRenderer = c57.AddComponent<SpriteRenderer>();
        c57SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c57SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c57SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c57Pressed = false;
        animations[17].spriteRenderer = c57SpriteRenderer;

        c67 = new GameObject("c67");
        c67.layer = 5;
        c67SpriteRenderer = c67.AddComponent<SpriteRenderer>();
        c67SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c67SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c67SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c77 = new GameObject("c77");
        c77.layer = 5;
        c77SpriteRenderer = c77.AddComponent<SpriteRenderer>();
        c77SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c77SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c77SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c77Pressed = false;
        animations[18].spriteRenderer = c77SpriteRenderer;

        c87 = new GameObject("c87");
        c87.layer = 5;
        c87SpriteRenderer = c87.AddComponent<SpriteRenderer>();
        c87SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c87SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c87SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c97 = new GameObject("c97");
        c97.layer = 5;
        c97SpriteRenderer = c97.AddComponent<SpriteRenderer>();
        c97SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c97SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c97SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c97Pressed = false;
        animations[19].spriteRenderer = c97SpriteRenderer;

        ca7 = new GameObject("ca7");
        ca7.layer = 5;
        ca7SpriteRenderer = ca7.AddComponent<SpriteRenderer>();
        ca7SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca7SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca7SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c08 = new GameObject("c08");
        c08.layer = 5;
        c08SpriteRenderer = c08.AddComponent<SpriteRenderer>();
        c08SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c08SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c08SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c18 = new GameObject("c18");
        c18.layer = 5;
        c18SpriteRenderer = c18.AddComponent<SpriteRenderer>();
        c18SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c18SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c18SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c28 = new GameObject("c28");
        c28.layer = 5;
        c28SpriteRenderer = c28.AddComponent<SpriteRenderer>();
        c28SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c28SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c28SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c38 = new GameObject("c38");
        c38.layer = 5;
        c38SpriteRenderer = c38.AddComponent<SpriteRenderer>();
        c38SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c38SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c38SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c48 = new GameObject("c48");
        c48.layer = 5;
        c48SpriteRenderer = c48.AddComponent<SpriteRenderer>();
        c48SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c48SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c48SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c58 = new GameObject("c58");
        c58.layer = 5;
        c58SpriteRenderer = c58.AddComponent<SpriteRenderer>();
        c58SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c58SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c58SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c68 = new GameObject("c68");
        c68.layer = 5;
        c68SpriteRenderer = c68.AddComponent<SpriteRenderer>();
        c68SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c68SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c68SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c78 = new GameObject("c78");
        c78.layer = 5;
        c78SpriteRenderer = c78.AddComponent<SpriteRenderer>();
        c78SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c78SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c78SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c88 = new GameObject("c88");
        c88.layer = 5;
        c88SpriteRenderer = c88.AddComponent<SpriteRenderer>();
        c88SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c88SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c88SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c98 = new GameObject("c98");
        c98.layer = 5;
        c98SpriteRenderer = c98.AddComponent<SpriteRenderer>();
        c98SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c98SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c98SpriteRenderer.size = new Vector2(5.0F, 1.0F);

        ca8 = new GameObject("ca8");
        ca8.layer = 5;
        ca8SpriteRenderer = ca8.AddComponent<SpriteRenderer>();
        ca8SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca8SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca8SpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c09 = new GameObject("c09");
        c09.layer = 5;
        c09SpriteRenderer = c09.AddComponent<SpriteRenderer>();
        c09SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c09SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c09SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c19 = new GameObject("c19");
        c19.layer = 5;
        c19SpriteRenderer = c19.AddComponent<SpriteRenderer>();
        c19SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c19SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c19SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c19Pressed = false;
        animations[20].spriteRenderer = c19SpriteRenderer;

        c29 = new GameObject("c29");
        c29.layer = 5;
        c29SpriteRenderer = c29.AddComponent<SpriteRenderer>();
        c29SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c29SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c29SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c39 = new GameObject("c39");
        c39.layer = 5;
        c39SpriteRenderer = c39.AddComponent<SpriteRenderer>();
        c39SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c39SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c39SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c39Pressed = false;
        animations[21].spriteRenderer = c39SpriteRenderer;

        c49 = new GameObject("c49");
        c49.layer = 5;
        c49SpriteRenderer = c49.AddComponent<SpriteRenderer>();
        c49SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c49SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c49SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c59 = new GameObject("c59");
        c59.layer = 5;
        c59SpriteRenderer = c59.AddComponent<SpriteRenderer>();
        c59SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c59SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c59SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c59Pressed = false;
        animations[22].spriteRenderer = c59SpriteRenderer;

        c69 = new GameObject("c69");
        c69.layer = 5;
        c69SpriteRenderer = c69.AddComponent<SpriteRenderer>();
        c69SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c69SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c69SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c79 = new GameObject("c79");
        c79.layer = 5;
        c79SpriteRenderer = c79.AddComponent<SpriteRenderer>();
        c79SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c79SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c79SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c79Pressed = false;
        animations[23].spriteRenderer = c79SpriteRenderer;

        c89 = new GameObject("c89");
        c89.layer = 5;
        c89SpriteRenderer = c89.AddComponent<SpriteRenderer>();
        c89SpriteRenderer.sprite = Resources.Load<Sprite>("Images/pass");
        c89SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c89SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c99 = new GameObject("c99");
        c99.layer = 5;
        c99SpriteRenderer = c99.AddComponent<SpriteRenderer>();
        c99SpriteRenderer.sprite = Resources.Load<Sprite>("Images/floor");
        c99SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c99SpriteRenderer.size = new Vector2(5.0F, 5.0F);
        c99Pressed = false;
        animations[24].spriteRenderer = c99SpriteRenderer;

        ca9 = new GameObject("ca9");
        ca9.layer = 5;
        ca9SpriteRenderer = ca9.AddComponent<SpriteRenderer>();
        ca9SpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        ca9SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ca9SpriteRenderer.size = new Vector2(1.0F, 5.0F);

        c0a = new GameObject("c0a");
        c0a.layer = 5;
        c0aSpriteRenderer = c0a.AddComponent<SpriteRenderer>();
        c0aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c0aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c0aSpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c1a = new GameObject("c1a");
        c1a.layer = 5;
        c1aSpriteRenderer = c1a.AddComponent<SpriteRenderer>();
        c1aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c1aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c1aSpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c2a = new GameObject("c2a");
        c2a.layer = 5;
        c2aSpriteRenderer = c2a.AddComponent<SpriteRenderer>();
        c2aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c2aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c2aSpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c3a = new GameObject("c3a");
        c3a.layer = 5;
        c3aSpriteRenderer = c3a.AddComponent<SpriteRenderer>();
        c3aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c3aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c3aSpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c4a = new GameObject("c4a");
        c4a.layer = 5;
        c4aSpriteRenderer = c4a.AddComponent<SpriteRenderer>();
        c4aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c4aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c4aSpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c5a = new GameObject("c5a");
        c5a.layer = 5;
        c5aSpriteRenderer = c5a.AddComponent<SpriteRenderer>();
        c5aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c5aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c5aSpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c6a = new GameObject("c6a");
        c6a.layer = 5;
        c6aSpriteRenderer = c6a.AddComponent<SpriteRenderer>();
        c6aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c6aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c6aSpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c7a = new GameObject("c7a");
        c7a.layer = 5;
        c7aSpriteRenderer = c7a.AddComponent<SpriteRenderer>();
        c7aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c7aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c7aSpriteRenderer.size = new Vector2(5.0F, 1.0F);

        c8a = new GameObject("c8a");
        c8a.layer = 5;
        c8aSpriteRenderer = c8a.AddComponent<SpriteRenderer>();
        c8aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c8aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c8aSpriteRenderer.size = new Vector2(1.0F, 1.0F);

        c9a = new GameObject("c9a");
        c9a.layer = 5;
        c9aSpriteRenderer = c9a.AddComponent<SpriteRenderer>();
        c9aSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        c9aSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        c9aSpriteRenderer.size = new Vector2(5.0F, 1.0F);

        caa = new GameObject("caa");
        caa.layer = 5;
        caaSpriteRenderer = caa.AddComponent<SpriteRenderer>();
        caaSpriteRenderer.sprite = Resources.Load<Sprite>("Images/wall");
        caaSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        caaSpriteRenderer.size = new Vector2(1.0F, 1.0F);
        #endregion

        #region Choices panel
        chbox = new GameObject("chbox");
        chbox.layer = 5;
        chboxSpriteRenderer = chbox.AddComponent<SpriteRenderer>();
        chboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        chboxSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        chboxSpriteRenderer.size = new Vector2(15.0F, 3.0F);

        ch1 = new GameObject("ch1");
        ch1.layer = 5;
        ch1SpriteRenderer = ch1.AddComponent<SpriteRenderer>();
        ch1SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        ch1SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ch1SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        ch1Pressed = false;

        ch2 = new GameObject("ch2");
        ch2.layer = 5;
        ch2SpriteRenderer = ch2.AddComponent<SpriteRenderer>();
        ch2SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        ch2SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ch2SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        ch2Pressed = false;

        ch3 = new GameObject("ch3");
        ch3.layer = 5;
        ch3SpriteRenderer = ch3.AddComponent<SpriteRenderer>();
        ch3SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        ch3SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ch3SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        ch3Pressed = false;

        ch4 = new GameObject("ch4");
        ch4.layer = 5;
        ch4SpriteRenderer = ch4.AddComponent<SpriteRenderer>();
        ch4SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        ch4SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ch4SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        ch4Pressed = false;

        ch5 = new GameObject("ch5");
        ch5.layer = 5;
        ch5SpriteRenderer = ch5.AddComponent<SpriteRenderer>();
        ch5SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        ch5SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        ch5SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        ch5Pressed = false;

        stbox = new GameObject("stbox");
        stbox.layer = 5;
        stboxSpriteRenderer = stbox.AddComponent<SpriteRenderer>();
        stboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        stboxSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        stboxSpriteRenderer.size = new Vector2(15.0F, 3.0F);

        st1 = new GameObject("st1");
        st1.layer = 5;
        st1SpriteRenderer = st1.AddComponent<SpriteRenderer>();
        st1SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        st1SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        st1SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        st1Pressed = false;

        st2 = new GameObject("st2");
        st2.layer = 5;
        st2SpriteRenderer = st2.AddComponent<SpriteRenderer>();
        st2SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        st2SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        st2SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        st2Pressed = false;

        st3 = new GameObject("st3");
        st3.layer = 5;
        st3SpriteRenderer = st3.AddComponent<SpriteRenderer>();
        st3SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        st3SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        st3SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        st3Pressed = false;

        st4 = new GameObject("st4");
        st4.layer = 5;
        st4SpriteRenderer = st4.AddComponent<SpriteRenderer>();
        st4SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        st4SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        st4SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        st4Pressed = false;

        st5 = new GameObject("st5");
        st5.layer = 5;
        st5SpriteRenderer = st5.AddComponent<SpriteRenderer>();
        st5SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        st5SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        st5SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        st5Pressed = false;

        spbox = new GameObject("spbox");
        spbox.layer = 5;
        spboxSpriteRenderer = spbox.AddComponent<SpriteRenderer>();
        spboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        spboxSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        spboxSpriteRenderer.size = new Vector2(15.0F, 3.0F);

        sp1 = new GameObject("sp1");
        sp1.layer = 5;
        sp1SpriteRenderer = sp1.AddComponent<SpriteRenderer>();
        sp1SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        sp1SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        sp1SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        sp1Pressed = false;

        sp2 = new GameObject("sp2");
        sp2.layer = 5;
        sp2SpriteRenderer = sp2.AddComponent<SpriteRenderer>();
        sp2SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        sp2SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        sp2SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        sp2Pressed = false;

        sp3 = new GameObject("sp3");
        sp3.layer = 5;
        sp3SpriteRenderer = sp3.AddComponent<SpriteRenderer>();
        sp3SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        sp3SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        sp3SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        sp3Pressed = false;

        sp4 = new GameObject("sp4");
        sp4.layer = 5;
        sp4SpriteRenderer = sp4.AddComponent<SpriteRenderer>();
        sp4SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        sp4SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        sp4SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        sp4Pressed = false;

        sp5 = new GameObject("sp5");
        sp5.layer = 5;
        sp5SpriteRenderer = sp5.AddComponent<SpriteRenderer>();
        sp5SpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        sp5SpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        sp5SpriteRenderer.size = new Vector2(3.0F, 3.0F);
        sp5Pressed = false;
        #endregion

        errbox = new GameObject("errbox");
        errbox.layer = 5;
        errboxSpriteRenderer = errbox.AddComponent<SpriteRenderer>();
        errboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/blank");
        errboxSpriteRenderer.drawMode = SpriteDrawMode.Tiled;
        errboxSpriteRenderer.size = new Vector2(50.0F, 3.0F);

        msgbox = new GameObject("msgbox");
        msgbox.layer = 5;
        msgboxSpriteRenderer = msgbox.AddComponent<SpriteRenderer>();
        msgboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/move");
    }

    private void DisableUi()
    {
        isUiEnabled = false;

        Destroy(musicbox);
        musicbox = null;
        musicboxSpriteRenderer = null;
        musicboxPressed = false;

        Destroy(floorbox);
        floorbox = null;
        floorboxSpriteRenderer = null;

        Destroy(labelf);
        labelf = null;

        Destroy(fnum);
        fnum = null;
        fnumSpriteRenderer = null;

        #region Levels panel
        Destroy(level);
        level = null;

        Destroy(charm);
        charm = null;

        Destroy(chlev);
        chlev = null;
        chlevSpriteRenderer = null;

        Destroy(chb1);
        chb1 = null;
        chb1SpriteRenderer = null;

        Destroy(chb2);
        chb2 = null;
        chb2SpriteRenderer = null;

        Destroy(chb3);
        chb3 = null;
        chb3SpriteRenderer = null;

        Destroy(chb4);
        chb4 = null;
        chb4SpriteRenderer = null;

        Destroy(chb5);
        chb5 = null;
        chb5SpriteRenderer = null;

        Destroy(chb6);
        chb6 = null;
        chb6SpriteRenderer = null;

        Destroy(chb7);
        chb7 = null;
        chb7SpriteRenderer = null;

        Destroy(chb8);
        chb8 = null;
        chb8SpriteRenderer = null;

        Destroy(chb9);
        chb9 = null;
        chb9SpriteRenderer = null;

        Destroy(chb10);
        chb10 = null;
        chb10SpriteRenderer = null;

        Destroy(stealth);
        stealth = null;

        Destroy(stlev);
        stlev = null;
        stlevSpriteRenderer = null;

        Destroy(stb1);
        stb1 = null;
        stb1SpriteRenderer = null;

        Destroy(stb2);
        stb2 = null;
        stb2SpriteRenderer = null;

        Destroy(stb3);
        stb3 = null;
        stb3SpriteRenderer = null;

        Destroy(stb4);
        stb4 = null;
        stb4SpriteRenderer = null;

        Destroy(stb5);
        stb5 = null;
        stb5SpriteRenderer = null;

        Destroy(stb6);
        stb6 = null;
        stb6SpriteRenderer = null;

        Destroy(stb7);
        stb7 = null;
        stb7SpriteRenderer = null;

        Destroy(stb8);
        stb8 = null;
        stb8SpriteRenderer = null;

        Destroy(stb9);
        stb9 = null;
        stb9SpriteRenderer = null;

        Destroy(stb10);
        stb10 = null;
        stb10SpriteRenderer = null;

        Destroy(spnknss);
        spnknss = null;

        Destroy(splev);
        splev = null;
        splevSpriteRenderer = null;

        Destroy(spb1);
        spb1 = null;
        spb1SpriteRenderer = null;

        Destroy(spb2);
        spb2 = null;
        spb2SpriteRenderer = null;

        Destroy(spb3);
        spb3 = null;
        spb3SpriteRenderer = null;

        Destroy(spb4);
        spb4 = null;
        spb4SpriteRenderer = null;

        Destroy(spb5);
        spb5 = null;
        spb5SpriteRenderer = null;

        Destroy(spb6);
        spb6 = null;
        spb6SpriteRenderer = null;

        Destroy(spb7);
        spb7 = null;
        spb7SpriteRenderer = null;

        Destroy(spb8);
        spb8 = null;
        spb8SpriteRenderer = null;

        Destroy(spb9);
        spb9 = null;
        spb9SpriteRenderer = null;

        Destroy(spb10);
        spb10 = null;
        spb10SpriteRenderer = null;
        #endregion

        #region Map panel
        Destroy(c00);
        c00 = null;
        c00SpriteRenderer = null;

        Destroy(c10);
        c10 = null;
        c10SpriteRenderer = null;

        Destroy(c20);
        c20 = null;
        c20SpriteRenderer = null;

        Destroy(c30);
        c30 = null;
        c30SpriteRenderer = null;

        Destroy(c40);
        c40 = null;
        c40SpriteRenderer = null;

        Destroy(c50);
        c50 = null;
        c50SpriteRenderer = null;

        Destroy(c60);
        c60 = null;
        c60SpriteRenderer = null;

        Destroy(c70);
        c70 = null;
        c70SpriteRenderer = null;

        Destroy(c80);
        c80 = null;
        c80SpriteRenderer = null;

        Destroy(c90);
        c90 = null;
        c90SpriteRenderer = null;

        Destroy(ca0);
        ca0 = null;
        ca0SpriteRenderer = null;

        Destroy(c01);
        c01 = null;
        c01SpriteRenderer = null;

        Destroy(c11);
        c11 = null;
        c11SpriteRenderer = null;
        c11Pressed = false;

        Destroy(c21);
        c21 = null;
        c21SpriteRenderer = null;

        Destroy(c31);
        c31 = null;
        c31SpriteRenderer = null;
        c31Pressed = false;

        Destroy(c41);
        c41 = null;
        c41SpriteRenderer = null;

        Destroy(c51);
        c51 = null;
        c51SpriteRenderer = null;
        c51Pressed = false;

        Destroy(c61);
        c61 = null;
        c61SpriteRenderer = null;

        Destroy(c71);
        c71 = null;
        c71SpriteRenderer = null;
        c71Pressed = false;

        Destroy(c81);
        c81 = null;
        c81SpriteRenderer = null;

        Destroy(c91);
        c91 = null;
        c91SpriteRenderer = null;
        c91Pressed = false;

        Destroy(ca1);
        ca1 = null;
        ca1SpriteRenderer = null;

        Destroy(c02);
        c02 = null;
        c02SpriteRenderer = null;

        Destroy(c12);
        c12 = null;
        c12SpriteRenderer = null;

        Destroy(c22);
        c22 = null;
        c22SpriteRenderer = null;

        Destroy(c32);
        c32 = null;
        c32SpriteRenderer = null;

        Destroy(c42);
        c42 = null;
        c42SpriteRenderer = null;

        Destroy(c52);
        c52 = null;
        c52SpriteRenderer = null;

        Destroy(c62);
        c62 = null;
        c62SpriteRenderer = null;

        Destroy(c72);
        c72 = null;
        c72SpriteRenderer = null;

        Destroy(c82);
        c82 = null;
        c82SpriteRenderer = null;

        Destroy(c92);
        c92 = null;
        c92SpriteRenderer = null;

        Destroy(ca2);
        ca2 = null;
        ca2SpriteRenderer = null;

        Destroy(c03);
        c03 = null;
        c03SpriteRenderer = null;

        Destroy(c13);
        c13 = null;
        c13SpriteRenderer = null;
        c13Pressed = false;

        Destroy(c23);
        c23 = null;
        c23SpriteRenderer = null;

        Destroy(c33);
        c33 = null;
        c33SpriteRenderer = null;
        c33Pressed = false;

        Destroy(c43);
        c43 = null;
        c43SpriteRenderer = null;

        Destroy(c53);
        c53 = null;
        c53SpriteRenderer = null;
        c53Pressed = false;

        Destroy(c63);
        c63 = null;
        c63SpriteRenderer = null;

        Destroy(c73);
        c73 = null;
        c73SpriteRenderer = null;
        c73Pressed = false;

        Destroy(c83);
        c83 = null;
        c83SpriteRenderer = null;

        Destroy(c93);
        c93 = null;
        c93SpriteRenderer = null;
        c93Pressed = false;

        Destroy(ca3);
        ca3 = null;
        ca3SpriteRenderer = null;

        Destroy(c04);
        c04 = null;
        c04SpriteRenderer = null;

        Destroy(c14);
        c14 = null;
        c14SpriteRenderer = null;

        Destroy(c24);
        c24 = null;
        c24SpriteRenderer = null;

        Destroy(c34);
        c34 = null;
        c34SpriteRenderer = null;

        Destroy(c44);
        c44 = null;
        c44SpriteRenderer = null;

        Destroy(c54);
        c54 = null;
        c54SpriteRenderer = null;

        Destroy(c64);
        c64 = null;
        c64SpriteRenderer = null;

        Destroy(c74);
        c74 = null;
        c74SpriteRenderer = null;

        Destroy(c84);
        c84 = null;
        c84SpriteRenderer = null;

        Destroy(c94);
        c94 = null;
        c94SpriteRenderer = null;

        Destroy(ca4);
        ca4 = null;
        ca4SpriteRenderer = null;

        Destroy(c05);
        c05 = null;
        c05SpriteRenderer = null;

        Destroy(c15);
        c15 = null;
        c15SpriteRenderer = null;
        c15Pressed = false;

        Destroy(c25);
        c25 = null;
        c25SpriteRenderer = null;

        Destroy(c35);
        c35 = null;
        c35SpriteRenderer = null;
        c35Pressed = false;

        Destroy(c45);
        c45 = null;
        c45SpriteRenderer = null;

        Destroy(c55);
        c55 = null;
        c55SpriteRenderer = null;
        c55Pressed = false;

        Destroy(c65);
        c65 = null;
        c65SpriteRenderer = null;

        Destroy(c75);
        c75 = null;
        c75SpriteRenderer = null;
        c75Pressed = false;

        Destroy(c85);
        c85 = null;
        c85SpriteRenderer = null;

        Destroy(c95);
        c95 = null;
        c95SpriteRenderer = null;
        c95Pressed = false;

        Destroy(ca5);
        ca5 = null;
        ca5SpriteRenderer = null;

        Destroy(c06);
        c06 = null;
        c06SpriteRenderer = null;

        Destroy(c16);
        c16 = null;
        c16SpriteRenderer = null;

        Destroy(c26);
        c26 = null;
        c26SpriteRenderer = null;

        Destroy(c36);
        c36 = null;
        c36SpriteRenderer = null;

        Destroy(c46);
        c46 = null;
        c46SpriteRenderer = null;

        Destroy(c56);
        c56 = null;
        c56SpriteRenderer = null;

        Destroy(c66);
        c66 = null;
        c66SpriteRenderer = null;

        Destroy(c76);
        c76 = null;
        c76SpriteRenderer = null;

        Destroy(c86);
        c86 = null;
        c86SpriteRenderer = null;

        Destroy(c96);
        c96 = null;
        c96SpriteRenderer = null;

        Destroy(ca6);
        ca6 = null;
        ca6SpriteRenderer = null;

        Destroy(c07);
        c07 = null;
        c07SpriteRenderer = null;

        Destroy(c17);
        c17 = null;
        c17SpriteRenderer = null;
        c17Pressed = false;

        Destroy(c27);
        c27 = null;
        c27SpriteRenderer = null;

        Destroy(c37);
        c37 = null;
        c37SpriteRenderer = null;
        c37Pressed = false;

        Destroy(c47);
        c47 = null;
        c47SpriteRenderer = null;

        Destroy(c57);
        c57 = null;
        c57SpriteRenderer = null;
        c57Pressed = false;

        Destroy(c67);
        c67 = null;
        c67SpriteRenderer = null;

        Destroy(c77);
        c77 = null;
        c77SpriteRenderer = null;
        c77Pressed = false;

        Destroy(c87);
        c87 = null;
        c87SpriteRenderer = null;

        Destroy(c97);
        c97 = null;
        c97SpriteRenderer = null;
        c97Pressed = false;

        Destroy(ca7);
        ca7 = null;
        ca7SpriteRenderer = null;

        Destroy(c08);
        c08 = null;
        c08SpriteRenderer = null;

        Destroy(c18);
        c18 = null;
        c18SpriteRenderer = null;

        Destroy(c28);
        c28 = null;
        c28SpriteRenderer = null;

        Destroy(c38);
        c38 = null;
        c38SpriteRenderer = null;

        Destroy(c48);
        c48 = null;
        c48SpriteRenderer = null;

        Destroy(c58);
        c58 = null;
        c58SpriteRenderer = null;

        Destroy(c68);
        c68 = null;
        c68SpriteRenderer = null;

        Destroy(c78);
        c78 = null;
        c78SpriteRenderer = null;

        Destroy(c88);
        c88 = null;
        c88SpriteRenderer = null;

        Destroy(c98);
        c98 = null;
        c98SpriteRenderer = null;

        Destroy(ca8);
        ca8 = null;
        ca8SpriteRenderer = null;

        Destroy(c09);
        c09 = null;
        c09SpriteRenderer = null;

        Destroy(c19);
        c19 = null;
        c19SpriteRenderer = null;
        c19Pressed = false;

        Destroy(c29);
        c29 = null;
        c29SpriteRenderer = null;

        Destroy(c39);
        c39 = null;
        c39SpriteRenderer = null;
        c39Pressed = false;

        Destroy(c49);
        c49 = null;
        c49SpriteRenderer = null;

        Destroy(c59);
        c59 = null;
        c59SpriteRenderer = null;
        c59Pressed = false;

        Destroy(c69);
        c69 = null;
        c69SpriteRenderer = null;

        Destroy(c79);
        c79 = null;
        c79SpriteRenderer = null;
        c79Pressed = false;

        Destroy(c89);
        c89 = null;
        c89SpriteRenderer = null;

        Destroy(c99);
        c99 = null;
        c99SpriteRenderer = null;
        c99Pressed = false;

        Destroy(ca9);
        ca9 = null;
        ca9SpriteRenderer = null;

        Destroy(c0a);
        c0a = null;
        c0aSpriteRenderer = null;

        Destroy(c1a);
        c1a = null;
        c1aSpriteRenderer = null;

        Destroy(c2a);
        c2a = null;
        c2aSpriteRenderer = null;

        Destroy(c3a);
        c3a = null;
        c3aSpriteRenderer = null;

        Destroy(c4a);
        c4a = null;
        c4aSpriteRenderer = null;

        Destroy(c5a);
        c5a = null;
        c5aSpriteRenderer = null;

        Destroy(c6a);
        c6a = null;
        c6aSpriteRenderer = null;

        Destroy(c7a);
        c7a = null;
        c7aSpriteRenderer = null;

        Destroy(c8a);
        c8a = null;
        c8aSpriteRenderer = null;

        Destroy(c9a);
        c9a = null;
        c9aSpriteRenderer = null;

        Destroy(caa);
        caa = null;
        caaSpriteRenderer = null;
        #endregion

        #region Choices panel
        Destroy(chbox);
        chbox = null;
        chboxSpriteRenderer = null;

        Destroy(ch1);
        ch1 = null;
        ch1SpriteRenderer = null;
        ch1Pressed = false;

        Destroy(ch2);
        ch2 = null;
        ch2SpriteRenderer = null;
        ch2Pressed = false;

        Destroy(ch3);
        ch3 = null;
        ch3SpriteRenderer = null;
        ch3Pressed = false;

        Destroy(ch4);
        ch4 = null;
        ch4SpriteRenderer = null;
        ch4Pressed = false;

        Destroy(ch5);
        ch5 = null;
        ch5SpriteRenderer = null;
        ch5Pressed = false;

        Destroy(stbox);
        stbox = null;
        stboxSpriteRenderer = null;

        Destroy(st1);
        st1 = null;
        st1SpriteRenderer = null;
        st1Pressed = false;

        Destroy(st2);
        st2 = null;
        st2SpriteRenderer = null;
        st2Pressed = false;

        Destroy(st3);
        st3 = null;
        st3SpriteRenderer = null;
        st3Pressed = false;

        Destroy(st4);
        st4 = null;
        st4SpriteRenderer = null;
        st4Pressed = false;

        Destroy(st5);
        st5 = null;
        st5SpriteRenderer = null;
        st5Pressed = false;

        Destroy(spbox);
        spbox = null;
        spboxSpriteRenderer = null;

        Destroy(sp1);
        sp1 = null;
        sp1SpriteRenderer = null;
        sp1Pressed = false;

        Destroy(sp2);
        sp2 = null;
        sp2SpriteRenderer = null;
        sp2Pressed = false;

        Destroy(sp3);
        sp3 = null;
        sp3SpriteRenderer = null;
        sp3Pressed = false;

        Destroy(sp4);
        sp4 = null;
        sp4SpriteRenderer = null;
        sp4Pressed = false;

        Destroy(sp5);
        sp5 = null;
        sp5SpriteRenderer = null;
        sp5Pressed = false;
        #endregion

        Destroy(errbox);
        errbox = null;
        errboxSpriteRenderer = null;

        Destroy(msgbox);
        msgbox = null;
        msgboxSpriteRenderer = null;
    }

    private void UpdateSprites()
    {
        CalculateWorkArea();

        if (isSplashEnabled)
        {
            ScaleSpriteToWorkArea(gameover1);
            SetSpritePosition(gameover1, 205, 142);

            ScaleSpriteToWorkArea(gameover2);
            SetSpritePosition(gameover2, 205, 257);

            ScaleSpriteToWorkArea(gameover3);
            SetSpritePosition(gameover3, 205, 287);
        }

        ScaleSpriteToWorkArea(splogo);
        SetLogoPosition(splogo, 330, 17);

        if (isUiEnabled)
        {
            ScaleSpriteToWorkArea(musicbox);
            SetSpritePosition(musicbox, 0.1F, 64);
            musicboxRect.xMin = (int)System.MathF.Round(interfaceWidth / 2.0F + -0.8F * Screen.width / Screen.height * interfaceWidth / workArea.width, System.MidpointRounding.AwayFromZero);
            musicboxRect.width = 250;

            ScaleSpriteToWorkArea(floorbox);
            SetSpritePosition(floorbox, 205, 110);

            ScaleSpriteToWorkArea(labelf);
            SetSpritePosition(labelf, 400, 140);

            ScaleSpriteToWorkArea(fnum);
            SetSpritePosition(fnum, 480, 140);

            #region Levels panel
            ScaleSpriteToWorkArea(level);
            SetSpritePosition(level, 0, 202);

            ScaleSpriteToWorkArea(charm);
            SetSpritePosition(charm, 0, 248);

            ScaleSpriteToWorkArea(chlev);
            SetSpritePosition(chlev, 150, 248);

            ScaleSpriteToWorkArea(chb1);
            SetSpritePosition(chb1, 0, 278);

            ScaleSpriteToWorkArea(chb2);
            SetSpritePosition(chb2, 15, 278);

            ScaleSpriteToWorkArea(chb3);
            SetSpritePosition(chb3, 30, 278);

            ScaleSpriteToWorkArea(chb4);
            SetSpritePosition(chb4, 45, 278);

            ScaleSpriteToWorkArea(chb5);
            SetSpritePosition(chb5, 60, 278);

            ScaleSpriteToWorkArea(chb6);
            SetSpritePosition(chb6, 75, 278);

            ScaleSpriteToWorkArea(chb7);
            SetSpritePosition(chb7, 90, 278);

            ScaleSpriteToWorkArea(chb8);
            SetSpritePosition(chb8, 105, 278);

            ScaleSpriteToWorkArea(chb9);
            SetSpritePosition(chb9, 120, 278);

            ScaleSpriteToWorkArea(chb10);
            SetSpritePosition(chb10, 135, 278);

            ScaleSpriteToWorkArea(stealth);
            SetSpritePosition(stealth, 0, 308);

            ScaleSpriteToWorkArea(stlev);
            SetSpritePosition(stlev, 150, 308);

            ScaleSpriteToWorkArea(stb1);
            SetSpritePosition(stb1, 0, 338);

            ScaleSpriteToWorkArea(stb2);
            SetSpritePosition(stb2, 15, 338);

            ScaleSpriteToWorkArea(stb3);
            SetSpritePosition(stb3, 30, 338);

            ScaleSpriteToWorkArea(stb4);
            SetSpritePosition(stb4, 45, 338);

            ScaleSpriteToWorkArea(stb5);
            SetSpritePosition(stb5, 60, 338);

            ScaleSpriteToWorkArea(stb6);
            SetSpritePosition(stb6, 75, 338);

            ScaleSpriteToWorkArea(stb7);
            SetSpritePosition(stb7, 90, 338);

            ScaleSpriteToWorkArea(stb8);
            SetSpritePosition(stb8, 105, 338);

            ScaleSpriteToWorkArea(stb9);
            SetSpritePosition(stb9, 120, 338);

            ScaleSpriteToWorkArea(stb10);
            SetSpritePosition(stb10, 135, 338);

            ScaleSpriteToWorkArea(spnknss);
            SetSpritePosition(spnknss, 0, 368);

            ScaleSpriteToWorkArea(splev);
            SetSpritePosition(splev, 150, 368);

            ScaleSpriteToWorkArea(spb1);
            SetSpritePosition(spb1, 0, 398);

            ScaleSpriteToWorkArea(spb2);
            SetSpritePosition(spb2, 15, 398);

            ScaleSpriteToWorkArea(spb3);
            SetSpritePosition(spb3, 30, 398);

            ScaleSpriteToWorkArea(spb4);
            SetSpritePosition(spb4, 45, 398);

            ScaleSpriteToWorkArea(spb5);
            SetSpritePosition(spb5, 60, 398);

            ScaleSpriteToWorkArea(spb6);
            SetSpritePosition(spb6, 75, 398);

            ScaleSpriteToWorkArea(spb7);
            SetSpritePosition(spb7, 90, 398);

            ScaleSpriteToWorkArea(spb8);
            SetSpritePosition(spb8, 105, 398);

            ScaleSpriteToWorkArea(spb9);
            SetSpritePosition(spb9, 120, 398);

            ScaleSpriteToWorkArea(spb10);
            SetSpritePosition(spb10, 135, 398);
            #endregion

            #region Map panel
            ScaleSpriteToWorkArea(c00);
            SetSpritePosition(c00, 300, 186);

            ScaleSpriteToWorkArea(c10);
            SetSpritePosition(c10, 310, 186);

            ScaleSpriteToWorkArea(c20);
            SetSpritePosition(c20, 360, 186);

            ScaleSpriteToWorkArea(c30);
            SetSpritePosition(c30, 370, 186);

            ScaleSpriteToWorkArea(c40);
            SetSpritePosition(c40, 420, 186);

            ScaleSpriteToWorkArea(c50);
            SetSpritePosition(c50, 430, 186);

            ScaleSpriteToWorkArea(c60);
            SetSpritePosition(c60, 480, 186);

            ScaleSpriteToWorkArea(c70);
            SetSpritePosition(c70, 490, 186);

            ScaleSpriteToWorkArea(c80);
            SetSpritePosition(c80, 540, 186);

            ScaleSpriteToWorkArea(c90);
            SetSpritePosition(c90, 550, 186);

            ScaleSpriteToWorkArea(ca0);
            SetSpritePosition(ca0, 600, 186);

            ScaleSpriteToWorkArea(c01);
            SetSpritePosition(c01, 300, 196);

            ScaleSpriteToWorkArea(c11);
            SetSpritePosition(c11, 310, 196);

            ScaleSpriteToWorkArea(c21);
            SetSpritePosition(c21, 360, 196);

            ScaleSpriteToWorkArea(c31);
            SetSpritePosition(c31, 370, 196);

            ScaleSpriteToWorkArea(c41);
            SetSpritePosition(c41, 420, 196);

            ScaleSpriteToWorkArea(c51);
            SetSpritePosition(c51, 430, 196);

            ScaleSpriteToWorkArea(c61);
            SetSpritePosition(c61, 480, 196);

            ScaleSpriteToWorkArea(c71);
            SetSpritePosition(c71, 490, 196);

            ScaleSpriteToWorkArea(c81);
            SetSpritePosition(c81, 540, 196);

            ScaleSpriteToWorkArea(c91);
            SetSpritePosition(c91, 550, 196);

            ScaleSpriteToWorkArea(ca1);
            SetSpritePosition(ca1, 600, 196);

            ScaleSpriteToWorkArea(c02);
            SetSpritePosition(c02, 300, 246);

            ScaleSpriteToWorkArea(c12);
            SetSpritePosition(c12, 310, 246);

            ScaleSpriteToWorkArea(c22);
            SetSpritePosition(c22, 360, 246);

            ScaleSpriteToWorkArea(c32);
            SetSpritePosition(c32, 370, 246);

            ScaleSpriteToWorkArea(c42);
            SetSpritePosition(c42, 420, 246);

            ScaleSpriteToWorkArea(c52);
            SetSpritePosition(c52, 430, 246);

            ScaleSpriteToWorkArea(c62);
            SetSpritePosition(c62, 480, 246);

            ScaleSpriteToWorkArea(c72);
            SetSpritePosition(c72, 490, 246);

            ScaleSpriteToWorkArea(c82);
            SetSpritePosition(c82, 540, 246);

            ScaleSpriteToWorkArea(c92);
            SetSpritePosition(c92, 550, 246);

            ScaleSpriteToWorkArea(ca2);
            SetSpritePosition(ca2, 600, 246);

            ScaleSpriteToWorkArea(c03);
            SetSpritePosition(c03, 300, 256);

            ScaleSpriteToWorkArea(c13);
            SetSpritePosition(c13, 310, 256);

            ScaleSpriteToWorkArea(c23);
            SetSpritePosition(c23, 360, 256);

            ScaleSpriteToWorkArea(c33);
            SetSpritePosition(c33, 370, 256);

            ScaleSpriteToWorkArea(c43);
            SetSpritePosition(c43, 420, 256);

            ScaleSpriteToWorkArea(c53);
            SetSpritePosition(c53, 430, 256);

            ScaleSpriteToWorkArea(c63);
            SetSpritePosition(c63, 480, 256);

            ScaleSpriteToWorkArea(c73);
            SetSpritePosition(c73, 490, 256);

            ScaleSpriteToWorkArea(c83);
            SetSpritePosition(c83, 540, 256);

            ScaleSpriteToWorkArea(c93);
            SetSpritePosition(c93, 550, 256);

            ScaleSpriteToWorkArea(ca3);
            SetSpritePosition(ca3, 600, 256);

            ScaleSpriteToWorkArea(c04);
            SetSpritePosition(c04, 300, 306);

            ScaleSpriteToWorkArea(c14);
            SetSpritePosition(c14, 310, 306);

            ScaleSpriteToWorkArea(c24);
            SetSpritePosition(c24, 360, 306);

            ScaleSpriteToWorkArea(c34);
            SetSpritePosition(c34, 370, 306);

            ScaleSpriteToWorkArea(c44);
            SetSpritePosition(c44, 420, 306);

            ScaleSpriteToWorkArea(c54);
            SetSpritePosition(c54, 430, 306);

            ScaleSpriteToWorkArea(c64);
            SetSpritePosition(c64, 480, 306);

            ScaleSpriteToWorkArea(c74);
            SetSpritePosition(c74, 490, 306);

            ScaleSpriteToWorkArea(c84);
            SetSpritePosition(c84, 540, 306);

            ScaleSpriteToWorkArea(c94);
            SetSpritePosition(c94, 550, 306);

            ScaleSpriteToWorkArea(ca4);
            SetSpritePosition(ca4, 600, 306);

            ScaleSpriteToWorkArea(c05);
            SetSpritePosition(c05, 300, 316);

            ScaleSpriteToWorkArea(c15);
            SetSpritePosition(c15, 310, 316);

            ScaleSpriteToWorkArea(c25);
            SetSpritePosition(c25, 360, 316);

            ScaleSpriteToWorkArea(c35);
            SetSpritePosition(c35, 370, 316);

            ScaleSpriteToWorkArea(c45);
            SetSpritePosition(c45, 420, 316);

            ScaleSpriteToWorkArea(c55);
            SetSpritePosition(c55, 430, 316);

            ScaleSpriteToWorkArea(c65);
            SetSpritePosition(c65, 480, 316);

            ScaleSpriteToWorkArea(c75);
            SetSpritePosition(c75, 490, 316);

            ScaleSpriteToWorkArea(c85);
            SetSpritePosition(c85, 540, 316);

            ScaleSpriteToWorkArea(c95);
            SetSpritePosition(c95, 550, 316);

            ScaleSpriteToWorkArea(ca5);
            SetSpritePosition(ca5, 600, 316);

            ScaleSpriteToWorkArea(c06);
            SetSpritePosition(c06, 300, 366);

            ScaleSpriteToWorkArea(c16);
            SetSpritePosition(c16, 310, 366);

            ScaleSpriteToWorkArea(c26);
            SetSpritePosition(c26, 360, 366);

            ScaleSpriteToWorkArea(c36);
            SetSpritePosition(c36, 370, 366);

            ScaleSpriteToWorkArea(c46);
            SetSpritePosition(c46, 420, 366);

            ScaleSpriteToWorkArea(c56);
            SetSpritePosition(c56, 430, 366);

            ScaleSpriteToWorkArea(c66);
            SetSpritePosition(c66, 480, 366);

            ScaleSpriteToWorkArea(c76);
            SetSpritePosition(c76, 490, 366);

            ScaleSpriteToWorkArea(c86);
            SetSpritePosition(c86, 540, 366);

            ScaleSpriteToWorkArea(c96);
            SetSpritePosition(c96, 550, 366);

            ScaleSpriteToWorkArea(ca6);
            SetSpritePosition(ca6, 600, 366);

            ScaleSpriteToWorkArea(c07);
            SetSpritePosition(c07, 300, 376);

            ScaleSpriteToWorkArea(c17);
            SetSpritePosition(c17, 310, 376);

            ScaleSpriteToWorkArea(c27);
            SetSpritePosition(c27, 360, 376);

            ScaleSpriteToWorkArea(c37);
            SetSpritePosition(c37, 370, 376);

            ScaleSpriteToWorkArea(c47);
            SetSpritePosition(c47, 420, 376);

            ScaleSpriteToWorkArea(c57);
            SetSpritePosition(c57, 430, 376);

            ScaleSpriteToWorkArea(c67);
            SetSpritePosition(c67, 480, 376);

            ScaleSpriteToWorkArea(c77);
            SetSpritePosition(c77, 490, 376);

            ScaleSpriteToWorkArea(c87);
            SetSpritePosition(c87, 540, 376);

            ScaleSpriteToWorkArea(c97);
            SetSpritePosition(c97, 550, 376);

            ScaleSpriteToWorkArea(ca7);
            SetSpritePosition(ca7, 600, 376);

            ScaleSpriteToWorkArea(c08);
            SetSpritePosition(c08, 300, 426);

            ScaleSpriteToWorkArea(c18);
            SetSpritePosition(c18, 310, 426);

            ScaleSpriteToWorkArea(c28);
            SetSpritePosition(c28, 360, 426);

            ScaleSpriteToWorkArea(c38);
            SetSpritePosition(c38, 370, 426);

            ScaleSpriteToWorkArea(c48);
            SetSpritePosition(c48, 420, 426);

            ScaleSpriteToWorkArea(c58);
            SetSpritePosition(c58, 430, 426);

            ScaleSpriteToWorkArea(c68);
            SetSpritePosition(c68, 480, 426);

            ScaleSpriteToWorkArea(c78);
            SetSpritePosition(c78, 490, 426);

            ScaleSpriteToWorkArea(c88);
            SetSpritePosition(c88, 540, 426);

            ScaleSpriteToWorkArea(c98);
            SetSpritePosition(c98, 550, 426);

            ScaleSpriteToWorkArea(ca8);
            SetSpritePosition(ca8, 600, 426);

            ScaleSpriteToWorkArea(c09);
            SetSpritePosition(c09, 300, 436);

            ScaleSpriteToWorkArea(c19);
            SetSpritePosition(c19, 310, 436);

            ScaleSpriteToWorkArea(c29);
            SetSpritePosition(c29, 360, 436);

            ScaleSpriteToWorkArea(c39);
            SetSpritePosition(c39, 370, 436);

            ScaleSpriteToWorkArea(c49);
            SetSpritePosition(c49, 420, 436);

            ScaleSpriteToWorkArea(c59);
            SetSpritePosition(c59, 430, 436);

            ScaleSpriteToWorkArea(c69);
            SetSpritePosition(c69, 480, 436);

            ScaleSpriteToWorkArea(c79);
            SetSpritePosition(c79, 490, 436);

            ScaleSpriteToWorkArea(c89);
            SetSpritePosition(c89, 540, 436);

            ScaleSpriteToWorkArea(c99);
            SetSpritePosition(c99, 550, 436);

            ScaleSpriteToWorkArea(ca9);
            SetSpritePosition(ca9, 600, 436);

            ScaleSpriteToWorkArea(c0a);
            SetSpritePosition(c0a, 300, 486);

            ScaleSpriteToWorkArea(c1a);
            SetSpritePosition(c1a, 310, 486);

            ScaleSpriteToWorkArea(c2a);
            SetSpritePosition(c2a, 360, 486);

            ScaleSpriteToWorkArea(c3a);
            SetSpritePosition(c3a, 370, 486);

            ScaleSpriteToWorkArea(c4a);
            SetSpritePosition(c4a, 420, 486);

            ScaleSpriteToWorkArea(c5a);
            SetSpritePosition(c5a, 430, 486);

            ScaleSpriteToWorkArea(c6a);
            SetSpritePosition(c6a, 480, 486);

            ScaleSpriteToWorkArea(c7a);
            SetSpritePosition(c7a, 490, 486);

            ScaleSpriteToWorkArea(c8a);
            SetSpritePosition(c8a, 540, 486);

            ScaleSpriteToWorkArea(c9a);
            SetSpritePosition(c9a, 550, 486);

            ScaleSpriteToWorkArea(caa);
            SetSpritePosition(caa, 600, 486);

            for (int index = 0; index < animations.Length; index += 1)
            {
                animations[index].Update();
            }
            #endregion

            #region Choices panel
            ScaleSpriteToWorkArea(chbox);
            SetSpritePosition(chbox, 710, 251);

            ScaleSpriteToWorkArea(ch1);
            SetSpritePosition(ch1, 710, 281);

            ScaleSpriteToWorkArea(ch2);
            SetSpritePosition(ch2, 740, 281);

            ScaleSpriteToWorkArea(ch3);
            SetSpritePosition(ch3, 770, 281);

            ScaleSpriteToWorkArea(ch4);
            SetSpritePosition(ch4, 800, 281);

            ScaleSpriteToWorkArea(ch5);
            SetSpritePosition(ch5, 830, 281);

            ScaleSpriteToWorkArea(stbox);
            SetSpritePosition(stbox, 710, 311);

            ScaleSpriteToWorkArea(st1);
            SetSpritePosition(st1, 710, 341);

            ScaleSpriteToWorkArea(st2);
            SetSpritePosition(st2, 740, 341);

            ScaleSpriteToWorkArea(st3);
            SetSpritePosition(st3, 770, 341);

            ScaleSpriteToWorkArea(st4);
            SetSpritePosition(st4, 800, 341);

            ScaleSpriteToWorkArea(st5);
            SetSpritePosition(st5, 830, 341);

            ScaleSpriteToWorkArea(spbox);
            SetSpritePosition(spbox, 710, 371);

            ScaleSpriteToWorkArea(sp1);
            SetSpritePosition(sp1, 710, 401);

            ScaleSpriteToWorkArea(sp2);
            SetSpritePosition(sp2, 740, 401);

            ScaleSpriteToWorkArea(sp3);
            SetSpritePosition(sp3, 770, 401);

            ScaleSpriteToWorkArea(sp4);
            SetSpritePosition(sp4, 800, 401);

            ScaleSpriteToWorkArea(sp5);
            SetSpritePosition(sp5, 830, 401);
            #endregion

            ScaleSpriteToWorkArea(errbox);
            SetSpritePosition(errbox, 205, 512);

            ScaleSpriteToWorkArea(msgbox);
            SetSpritePosition(msgbox, 205, 542);
        }
    }

    private void ScaleSpriteToWorkArea(GameObject sprite)
    {
        sprite.transform.localScale = new Vector3(10.0F / pixelsPerUnit, 10.0F / pixelsPerUnit, 1.0F);
    }

    private Vector2 GetWorkAreaPosition(int x, int y)
    {
        return new Vector2(workArea.x + x / interfaceWidth * workArea.width, workArea.y - y / interfaceHeight * workArea.height);
    }

    private Vector3 GetWorkAreaPosition(int x, int y, float z = 0.0F)
    {
        return new Vector3(workArea.x + x / interfaceWidth * workArea.width, workArea.y - y / interfaceHeight * workArea.height, z);
    }

    private void SetSpritePosition(GameObject sprite, int x, int y)
    {
        sprite.transform.position = GetWorkAreaPosition(x, y, sprite.transform.position.z);
    }

    private void SetSpritePosition(GameObject sprite, float xPercentage, int y)
    {
        sprite.transform.position = new Vector3((2.0F * xPercentage - 1.0F) * Screen.width / Screen.height, workArea.y - y / interfaceHeight * workArea.height, sprite.transform.position.z);
    }

    private void SetLogoPosition(GameObject logoSprite, int x, int y)
    {
        logoSprite.transform.position = GetWorkAreaPosition(x, y, logoSprite.transform.position.z);

        Vector3[] newPositions = new Vector3[4]
        {
            GetWorkAreaPosition(x, y, 0.0F),
            GetWorkAreaPosition(x + 250, y, 0.0F),
            GetWorkAreaPosition(x + 250, y + 30, 0.0F),
            GetWorkAreaPosition(x, y + 30, 0.0F)
        };
        splogoLineRenderer.SetPositions(newPositions);

        splogoLineRenderer.widthMultiplier = 2.0F / pixelsPerUnit;
    }

    private ref SimpleAnimation GetAnimation(int x, int y)
    {
        if (x % 2 == 0 || y % 2 == 0)
        {
            throw new UnityException("GameManager.GetAnimation: x and y must be both odd numbers.");
        }
        return ref animations[(y - 1) / 2 * 5 + (x - 1) / 2];
    }

    private void SetMapTile(int x, int y, string tile)
    {
        int z = xy(x, y);

        switch (tile)
        {
            case "unknown":
            case "floor":
            case "pass":
            case "wall":
            case "steps":
                GameObject.Find(view[z]).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/" + tile);
                if (x % 2 == 1 && y % 2 == 1)
                {
                    GetAnimation(x, y).Disable();
                }
                break;
            case "princess":
            case "pguard":
            case "pflunky":
            case "pservant":
            case "ptiger":
            case "gypsy":
                if (x % 2 == 1 && y % 2 == 1)
                {
                    GetAnimation(x, y).Enable(tile, new float[2] { 0.27F, 0.27F });
                }
                break;
            case "guard":
            case "servant":
            case "tiger":
                if (x % 2 == 1 && y % 2 == 1)
                {
                    GetAnimation(x, y).Enable(tile, new float[2] { 0.54F, 0.54F });
                }
                break;
            case "flunky":
                if (x % 2 == 1 && y % 2 == 1)
                {
                    GetAnimation(x, y).Enable(tile, new float[2] { 0.81F, 0.27F });
                }
                break;
            default:
                break;
        }
    }

    #region Script
    #region Messages
    void msg(string s)
    {
        msgboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/" + s);
    }

    void errmsg(string s)
    {
        errboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/" + s);
    }

    void floormsg(string s)
    {
        floorboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/" + s);
    }

    void gameover(string s1, string s2, string s3)
    {
        stopmusic();

        EnableSplash(Resources.Load<Sprite>("Images/" + s1), Resources.Load<Sprite>("Images/" + s2), Resources.Load<Sprite>("Images/" + s3));
        DisableUi();
    }
    #endregion

    #region Audio
    private bool musicdisallowed = true;

    void startmusic()
    {
        musicAudioSource.Play();
        musicboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/musicoff");
    }

    void stopmusic()
    {
        musicAudioSource.Stop();
        musicboxSpriteRenderer.sprite = Resources.Load<Sprite>("Images/musicon");
    }
    #endregion

    #region Utility
    int rnd(int n)
    {
        int value = Mathf.FloorToInt(Random.value * n);
        // Workaround difference with JavaScript Math.random
        return value == n ? 0 : value;
    }

    int div(int x, int y)
    {
        return (int)System.Math.Floor((double)x / y);
    }
    #endregion

    #region Stat selection
    string[][] statchoice = new string[3][]
    {
        new string[6] { "chbox", "ch1", "ch2", "ch3", "ch4", "ch5" },
        new string[6] { "stbox", "st1", "st2", "st3", "st4", "st5" },
        new string[6] { "spbox", "sp1", "sp2", "sp3", "sp4", "sp5" }
    };
    string[] attr = new string[3] { "charm", "stealth", "spnknss" };
    string[] expl = new string[3] { "lose2ch", "lose2st", "lose2sp" };
    string[] report = new string[6] { "chok", "stok", "spok", "chfail", "stfail", "spfail" };
    int[] clc = new int[24]
    {
        1, 2, 3, 5, 2, 4,       //guard
        3, 5, 1, 3, 1, 2,       //flunky
        1, 2, 1, 6, 1, 2,       //servant
        1, 6, 5, 6, 3, 4        //tiger
    };

    void smove(int nx, int ny)
    {
        int z = xy(nx, ny);

        map[z] = prev;
        prev = 0;
        if (sight[z])
        {
            SetMapTile(nx, ny, "servant");
            SetMapTile(px, py, "princess");
        }
    }

    void chose(int stat, int val)
    {
        if (movemode)
        {
            return;
        }
        else if (stats[stat] < val)
        {
            errmsg("notgot");
        }
        else
        {
            int i = (prev - 3) * 6 + 2 * stat;
            int lo = clc[i];
            int hi = clc[i + 1];
            int res = stat;

            i = rnd(hi - lo + 1) + lo;
            if (val < i)
            {
                val += 2 * (i - val);
                res += 3;
            }
            stats[stat] -= val;
            if (stats[stat] < 0)
            {
                gameover("lose1", expl[stat], "lose3");
            }
            else
            {
                showlev(stat);
                movemode = true;
                chboxSpriteRenderer.sprite =
                stboxSpriteRenderer.sprite =
                spboxSpriteRenderer.sprite =
                ch1SpriteRenderer.sprite =
                st1SpriteRenderer.sprite =
                sp1SpriteRenderer.sprite =
                ch2SpriteRenderer.sprite =
                st2SpriteRenderer.sprite =
                sp2SpriteRenderer.sprite =
                ch3SpriteRenderer.sprite =
                st3SpriteRenderer.sprite =
                sp3SpriteRenderer.sprite =
                ch4SpriteRenderer.sprite =
                st4SpriteRenderer.sprite =
                sp4SpriteRenderer.sprite =
                ch5SpriteRenderer.sprite =
                st5SpriteRenderer.sprite =
                sp5SpriteRenderer.sprite =
                    Resources.Load<Sprite>("Images/blank");
                reveal(px, py);
                if (prev == 5)
                {
                    switch (rnd(4))
                    {
                        case 0:
                            if (map[xy(px + 1, py)] == 0 && map[xy(px + 2, py)] == 0)
                            {
                                smove(px + 2, py);
                            }
                            break;
                        case 1:
                            if (map[xy(px - 1, py)] == 0 && map[xy(px - 2, py)] == 0)
                            {
                                smove(px - 2, py);
                            }
                            break;
                        case 2:
                            if (map[xy(px, py + 1)] == 0 && map[xy(px, py + 2)] == 0)
                            {
                                smove(px, py + 2);
                            }
                            break;
                        case 3:
                            if (map[xy(px, py - 1)] == 0 && map[xy(px, py - 2)] == 0)
                            {
                                smove(px, py - 2);
                            }
                            break;
                    }
                }
                errmsg(report[res]);
                msg("move");
            }
        }
    }
    #endregion

    #region Movement
    int px;
    int py;
    int prev;
    bool movemode;

    void move(int x, int y)
    {
        if (musicdisallowed)
        {
            musicdisallowed = false;
            startmusic();
        }
        errmsg("blank");
        floormsg("blank");
        if (x == 9 && y == 9)
        {
            nextfloor();
        }
        else
        {
            map[xy(px, py)] = prev;
            showview(px, py);
            px = x;
            py = y;
            prev = map[xy(px, py)];
            map[xy(px, py)] = 2;
            showview(px, py);
            reveal(px, py);
            if (prev != 0)
            {
                movemode = false;
                for (int j = 0; j < 3; j += 1)
                {
                    int stat = stats[j];
                    int k = (prev - 3) * 6 + 2 * j;
                    int lo = clc[k];
                    int hi = clc[k + 1];
                    if (stat > 0)
                    {
                        GameObject.Find(statchoice[j][0]).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/" + attr[j]);
                    }
                    for (int i = 1; i < 6; i += 1)
                    {
                        GameObject.Find(statchoice[j][i]).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(stat >= i ? "Images/" + (i < lo ? "red" : i < hi ? "amber" : "green") + i : "Images/blank");
                    }
                }
                msg("choose.gif");
            }
        }
    }

    bool ok(int x, int y)
    {
        int c = map[xy(x, y)];

        return c * c != 1;        //ie. c != 1 && c != -1
    }

    bool path(int sx, int sy, int fx, int fy)
    {
        int here = xy(sx, sy);

        if (sx == fx && sy == fy)
        {
            sight[here] = true;

            return true;
        }
        if (sight[here])
        {
            if (map[here] != 0)
            {
                return false;
            }
            if (map[xy(sx + 1, sy)] == 0)
            {
                if (ok(sx + 2, sy))
                {
                    map[here] = -1;
                    if (path(sx + 2, sy, fx, fy))
                    {
                        return true;
                    }
                }
            }
            if (map[xy(sx - 1, sy)] == 0)
            {
                if (ok(sx - 2, sy))
                {
                    map[here] = -1;
                    if (path(sx - 2, sy, fx, fy))
                    {
                        return true;
                    }
                }
            }
            if (map[xy(sx, sy + 1)] == 0)
            {
                if (ok(sx, sy + 2))
                {
                    map[here] = -1;
                    if (path(sx, sy + 2, fx, fy))
                    {
                        return true;
                    }
                }
            }
            if (map[xy(sx, sy - 1)] == 0)
            {
                if (ok(sx, sy - 2))
                {
                    map[here] = -1;
                    if (path(sx, sy - 2, fx, fy))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    bool route(int sx, int sy, int fx, int fy)
    {
        bool res;
        int here = xy(px, py);
        int current = map[here];

        map[here] = 0;
        res = path(sx, sy, fx, fy);
        for (int i = 0; i < 121; i += 1)
        {
            if (map[i] < 0)
            {
                map[i] = 0;
            }
        }
        map[here] = current;

        return res;
    }

    void pick(int x, int y)
    {
        if (x == px && y == py)
        {
            errmsg("in");
        }
        else if (movemode)
        {
            if (route(px, py, x, y))
            {
                move(x, y);
            }
            else
            {
                errmsg("nona");
            }
        }
        else
        {
            errmsg(prev == 6 ? "something" : "someone");
        }
    }
    #endregion

    #region Level creation
    int[] map = new int[121]
    {
        1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
        1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1,
        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
        1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1,
        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
        1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1,
        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
        1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1,
        1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
        1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1
    };
    string[] view = new string[121]
    {
        "c00", "c10", "c20", "c30", "c40", "c50", "c60", "c70", "c80", "c90", "ca0",
        "c01", "c11", "c21", "c31", "c41", "c51", "c61", "c71", "c81", "c91", "ca1",
        "c02", "c12", "c22", "c32", "c42", "c52", "c62", "c72", "c82", "c92", "ca2",
        "c03", "c13", "c23", "c33", "c43", "c53", "c63", "c73", "c83", "c93", "ca3",
        "c04", "c14", "c24", "c34", "c44", "c54", "c64", "c74", "c84", "c94", "ca4",
        "c05", "c15", "c25", "c35", "c45", "c55", "c65", "c75", "c85", "c95", "ca5",
        "c06", "c16", "c26", "c36", "c46", "c56", "c66", "c76", "c86", "c96", "ca6",
        "c07", "c17", "c27", "c37", "c47", "c57", "c67", "c77", "c87", "c97", "ca7",
        "c08", "c18", "c28", "c38", "c48", "c58", "c68", "c78", "c88", "c98", "ca8",
        "c09", "c19", "c29", "c39", "c49", "c59", "c69", "c79", "c89", "c99", "ca9",
        "c0a", "c1a", "c2a", "c3a", "c4a", "c5a", "c6a", "c7a", "c8a", "c9a", "caa"
    };
    string[][] levarr = new string[3][]
    {
        new string[11] { "chlev", "chb1", "chb2", "chb3", "chb4", "chb5", "chb6", "chb7", "chb8", "chb9", "chb10" },
        new string[11] { "stlev", "stb1", "stb2", "stb3", "stb4", "stb5", "stb6", "stb7", "stb8", "stb9", "stb10" },
        new string[11] { "splev", "spb1", "spb2", "spb3", "spb4", "spb5", "spb6", "spb7", "spb8", "spb9", "spb10" }
    };
    bool[] sight = new bool[121];
    int floor = 10;
    int[] stats = new int[3] { 10, 10, 10 };

    int xy(int x, int y)
    {
        return x + y * 11;
    }

    void clearsight()
    {
        for (int i = 0; i < 121; i += 1)
        {
            sight[i] = false;
        }
    }

    void explore(int x, int y)
    {
        int z = xy(x, y);

        if (map[z] == 0 && !sight[z])
        {
            sight[z] = true;
            explore(x + 1, y);
            explore(x - 1, y);
            explore(x, y + 1);
            explore(x, y - 1);
        }
    }

    void place(int o, int d)
    {
        int n = rnd(div(20 - floor, d)) + 1;

        while (n-- > 0)
        {
            int x = rnd(5) * 2 + 1;
            int y = rnd(5) * 2 + 1;
            int z = xy(x, y);

            if (map[z] == 0)
            {
                map[z] = o;
            }
        }
    }

    void showview(int x, int y)
    {
        int z = xy(x, y);
        string tile = null;

        switch (map[z])
        {
            case 0:
                tile = (y % 2 == 0 || x % 2 == 0) ? "pass" : sight[z] ? "floor" : "unknown";
                break;
            case 1:
                tile = "wall";
                break;
            case 2:
                tile = prev == 3 ? "pguard" : prev == 4 ? "pflunky" : prev == 5 ? "pservant" : prev == 6 ? "ptiger" : "princess";
                break;
            case 3:
                tile = sight[z] ? "guard" : "unknown";
                break;
            case 4:
                tile = sight[z] ? "flunky" : "unknown";
                break;
            case 5:
                tile = sight[z] ? "servant" : "unknown";
                break;
            case 6:
                tile = sight[z] ? "tiger" : "unknown";
                break;
            case 7:
                tile = "steps";
                break;
            case 8:
                tile = "gypsy";
                break;
        }
        SetMapTile(x, y, tile);
    }

    void reveal(int x, int y)
    {
        if (x < 9 && map[xy(x + 1, y)] == 0)
        {
            sight[xy(x + 2, y)] = true;
            showview(x + 2, y);
        }
        if (y < 9 && map[xy(x, y + 1)] == 0)
        {
            sight[xy(x, y + 2)] = true;
            showview(x, y + 2);
        }
        if (x > 1 && map[xy(x - 1, y)] == 0)
        {
            sight[xy(x - 2, y)] = true;
            showview(x - 2, y);
        }
        if (y > 1 && map[xy(x, y - 1)] == 0)
        {
            sight[xy(x, y - 2)] = true;
            showview(x, y - 2);
        }
    }

    void showlev(int a)
    {
        int n = stats[a];
        string[] arr = levarr[a];
        string lev = n <= 3 ? "Images/red" : n <= 7 ? "Images/yellow" : "Images/green";

        GameObject.Find(arr[0]).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/label" + n);
        for (int i = 1; i <= n; i += 1)
        {
            GameObject.Find(arr[i]).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(lev);
        }
        for (int i = n + 1; i <= 10; i += 1)
        {
            GameObject.Find(arr[i]).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/blank");
        }
    }

    void nextfloor()
    {
        bool doing = true;

        if (floor == 0)
        {
            gameover("win1", "win2", "win3");

            return;
        }
        floormsg(floor == 10 ? "start" : floor == 1 ? "end" : "descend");
        fnumSpriteRenderer.sprite = Resources.Load<Sprite>("Images/label" + floor);
        for (int i = 1; i < 10; i += 1)
        {
            for (int j = 1; j < 10; j += 1)
            {
                map[xy(i, j)] = (i % 2 == 0 && j % 2 == 0) ? 1 : 0;
            }
        }
        for (int k = 0; k < 20 - floor; k += 1)
        {
            int xx = rnd(4) * 2 + 2;
            int yy = rnd(5) * 2 + 1;

            if (rnd(2) == 0)
            {
                int zz = xx;

                xx = yy;
                yy = zz;
            }
            map[xy(xx, yy)] = 1;
        }
        while (doing)
        {
            doing = false;
            clearsight();
            explore(1, 1);

            for (int i = 1; i < 10; i += 2)
            {
                for (int j = 1; j < 10; j += 2)
                {
                    if (!sight[xy(i, j)])
                    {
                        if (i < 9 && map[xy(i + 1, j)] == 1)
                        {
                            map[xy(i + 1, j)] = 0;
                        }
                        else if (j < 9 && map[xy(i, j + 1)] == 1)
                        {
                            map[xy(i, j + 1)] = 0;
                        }
                        else if (i > 1 && map[xy(i - 1, j)] == 1)
                        {
                            map[xy(i - 1, j)] = 0;
                        }
                        else if (j > 1 && map[xy(i, j - 1)] == 1)
                        {
                            map[xy(i, j - 1)] = 0;
                        }

                        doing = true;
                        i = 11;

                        break;
                    }    
                }
            }
        }
        clearsight();
        px = 1;
        py = 1;
        prev = 0;
        movemode = true;
        map[xy(px, py)] = 2;
        sight[xy(px, py)] = true;
        map[xy(9, 9)] = floor == 1 ? 8 : 7;
        sight[xy(9, 9)] = true;
        place(6, 5);
        place(5, 4);
        place(4, 3);
        place(3, 2);
        reveal(1, 1);

        for (int i = 1; i < 10; i += 1)
        {
            for (int j = 1; j < 10; j += 1)
            {
                showview(i, j);
            }
        }
        for (int i = 0; i < 3; i += 1)
        {
            if (stats[i] < 10)
            {
                stats[i] += 1;
                doing = true;
                showlev(i);
            }
        }
        if (doing)
        {
            errmsg("rest");
        }
        floor -= 1;
    }
    #endregion
    #endregion
}
