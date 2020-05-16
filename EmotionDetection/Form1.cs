using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmotionDetection
{
    public partial class Form1 : Form
    {
        private SoundPlayer fear, angry, disgusted, happy;
        public Form1()
        {
            InitializeComponent();
            fear = new SoundPlayer("fear.wav");
            angry = new SoundPlayer("angry.wav");
            disgusted = new SoundPlayer("disgusted.wav");
            happy = new SoundPlayer("happy.wav");
        }

        private void disgusted_btn_Click(object sender, EventArgs e)
        {
            List<Emotion> response = this.EmotionDetect("disgusted.jpg"); // list emotions using aws rekonigtion
            this.ChooseMusicShowResponse( response); // play music and show emotions
            this.picArea.Image = EmotionDetection.Properties.Resources.disgusted; // slideshow picture

        }


        private void angry_btn_Click(object sender, EventArgs e)
        {
            List<Emotion> response = this.EmotionDetect("angry.jpg"); // list emotions using aws rekonigtion
            this.ChooseMusicShowResponse(response); // play music and show emotions
            this.picArea.Image = EmotionDetection.Properties.Resources.anrgy; // slideshow picture
        }

        private void fear_btn_Click(object sender, EventArgs e)
        {
            List<Emotion> response = this.EmotionDetect("fear.jpg"); // list emotions using aws rekonigtion
            this.ChooseMusicShowResponse(response); // play music and show emotions
            this.picArea.Image = EmotionDetection.Properties.Resources.fear; // slideshow picture
        }

        private void happy_btn_Click(object sender, EventArgs e)
        {
            List<Emotion> response = this.EmotionDetect("happy.jpg"); // list emotions using aws rekonigtion
            this.ChooseMusicShowResponse(response); // play music and show emotions
            this.picArea.Image = EmotionDetection.Properties.Resources.happy; // slideshow picture
        }

        public List<Emotion> EmotionDetect(string _image)
        {
            {
                String photo = _image;
                String bucket = "ngankhanh98";
                List<Emotion> response;

                AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();

                DetectFacesRequest detectFacesRequest = new DetectFacesRequest()
                {
                    Image = new Amazon.Rekognition.Model.Image()
                    {
                        S3Object = new S3Object()
                        {
                            Name = photo,
                            Bucket = bucket
                        },
                    },
                    Attributes = new List<String>() { "ALL" }
                };

                try
                {
                    DetectFacesResponse detectFacesResponse = rekognitionClient.DetectFaces(detectFacesRequest);
                    bool hasAll = detectFacesRequest.Attributes.Contains("ALL");
                    FaceDetail face = detectFacesResponse.FaceDetails[0];

                    return face.Emotions;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public void ChooseMusicShowResponse(List<Emotion> response)
        {
            response = response.OrderByDescending(emotion => emotion.Confidence).ToList();
            String _emotion = response[0].Type.ToString();
            _emotion = _emotion.ToLower();
            this.response.Text = "";
            switch (_emotion)
            {
                case "happy": happy.Play(); break;
                case "disgusted": disgusted.Play(); break;
                case "angry": angry.Play(); break;
                case "fear": fear.Play(); break;
                default:
                    break;
            }
            response.ForEach(res => this.response.Text += ("Type=" + res.Type + "; Confidence=" + res.Confidence + "\n"));
        }
    }
}

