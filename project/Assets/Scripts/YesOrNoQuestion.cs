using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Dan.Demo;

public class YesOrNoQuestion : MonoBehaviour
{
    public string[] Questions = {
    "Is the element <p> used to display a textual paragraph?",
    "Can the <img> element be used to insert images in an HTML page?",
    "Can the <a> element be used to create links in an HTML page?",
    "Can the <div> element be used to group elements together in an HTML page?",
    "Can the <input> element be used to create user input fields in an HTML page?",
    "Can the <ul> element be used to create unordered lists in an HTML page?",
    "Can the <table> element be used to create tables in an HTML page?",
    "Can the <span> element be used to style small parts of text in an HTML page?",
    "Can the <form> element be used to create forms in an HTML page?",
    "Can the <video> element be used to embed video clips in an HTML page?",
    "Can the <audio> element be used to embed audio files in an HTML page?",
    "Can the <h1> element be used to create main headings in an HTML page?",
    "Can the <nav> element be used to create a navigation menu in an HTML page?",
    "Can the <textarea> element be used to create multi-line text areas in an HTML page?",
    "Can the <button> element be used to create buttons in an HTML page?",
    "Can the <script> element be used to embed JavaScript interactions in an HTML page?",
    "Can the <canvas> element be used to draw graphics and designs in an HTML page?",
    "Can the <footer> element be used to display a footer section in an HTML page?",
    "Can the <header> element be used to display a header section in an HTML page?",
    "Can the <section> element be used to group specific sections in an HTML page?",
    "Can the <article> element be used to group independent content in an HTML page?",
    "Can the <aside> element be used to display sidebar content in an HTML page?",
    "Can the <time> element be used to display time and dates in an HTML page?",
    "Can the <progress> element be used to display a progress bar in an HTML page?",
    "Can the <label> element be used for labeling form controls in an HTML page?",
    "Can the <h1> element be used to create input fields in an HTML page?",
    "Can the <img> element be used to create tables in an HTML page?",
    "Can the <a> element be used to create unordered lists in an HTML page?",
    "Can the <div> element be used to insert images in an HTML page?",
    "Can the <input> element be used to create links in an HTML page?",
    "Can the <ul> element be used to create a header section in an HTML page?",
    "Can the <table> element be used to create multi-line text areas in an HTML page?",
    "Can the <span> element be used to create buttons in an HTML page?",
    "Can the <form> element be used to create a footer section in an HTML page?",
    "Can the <video> element be used to create links in an HTML page?",
    "Can the <audio> element be used to create tables in an HTML page?",
    "Can the <p> element be used to create unordered lists in an HTML page?",
    "Can the <nav> element be used to create sidebar content in an HTML page?",
    "Can the <textarea> element be used to draw graphics and designs in an HTML page?",
    "Can the <button> element be used to create a header section in an HTML page?",
    "Can the <script> element be used to create a textual paragraph in an HTML page?",
    "Can the <canvas> element be used to create main headings in an HTML page?",
    "Can the <footer> element be used to embed JavaScript interactions in an HTML page?"
    };
    public bool[] Answers = {
    true,  // Is the element <p> used to display a textual paragraph? - Yes
    true,  // Can the <img> element be used to insert images in an HTML page? - Yes
    true,  // Can the <a> element be used to create links in an HTML page? - Yes
    true,  // Can the <div> element be used to group elements together in an HTML page? - Yes
    true,  // Can the <input> element be used to create user input fields in an HTML page? - Yes
    true,  // Can the <ul> element be used to create unordered lists in an HTML page? - Yes
    true,  // Can the <table> element be used to create tables in an HTML page? - Yes
    true,  // Can the <span> element be used to style small parts of text in an HTML page? - Yes
    true,  // Can the <form> element be used to create forms in an HTML page? - Yes
    true,  // Can the <video> element be used to embed video clips in an HTML page? - Yes
    true,  // Can the <audio> element be used to embed audio files in an HTML page? - Yes
    true,  // Can the <h1> element be used to create main headings in an HTML page? - Yes
    true,  // Can the <nav> element be used to create a navigation menu in an HTML page? - Yes
    true,  // Can the <textarea> element be used to create multi-line text areas in an HTML page? - Yes
    true,  // Can the <button> element be used to create buttons in an HTML page? - Yes
    true,  // Can the <script> element be used to embed JavaScript interactions in an HTML page? - Yes
    true,  // Can the <canvas> element be used to draw graphics and designs in an HTML page? - Yes
    true,  // Can the <footer> element be used to display a footer section in an HTML page? - Yes
    true,  // Can the <header> element be used to display a header section in an HTML page? - Yes
    true,  // Can the <section> element be used to group specific sections in an HTML page? - Yes
    true,  // Can the <article> element be used to group independent content in an HTML page? - Yes
    true,  // Can the <aside> element be used to display sidebar content in an HTML page? - Yes
    true,  // Can the <time> element be used to display time and dates in an HTML page? - Yes
    true,  // Can the <progress> element be used to display a progress bar in an HTML page? - Yes
    true,  // Can the <label> element be used for labeling form controls in an HTML page? - Yes
    false, // Can the <h1> element be used to create input fields in an HTML page? - No
    false, // Can the <img> element be used to create tables in an HTML page? - No
    false, // Can the <a> element be used to create unordered lists in an HTML page? - No
    false, // Can the <div> element be used to insert images in an HTML page? - No
    false, // Can the <input> element be used to create links in an HTML page? - No
    false, // Can the <ul> element be used to create a header section in an HTML page? - No
    false, // Can the <table> element be used to create multi-line text areas in an HTML page? - No
    false, // Can the <span> element be used to create buttons in an HTML page? - No
    false, // Can the <form> element be used to create a footer section in an HTML page? - No
    false, // Can the <video> element be used to create links in an HTML page? - No
    false, // Can the <audio> element be used to create tables in an HTML page? - No
    false, // Can the <p> element be used to create unordered lists in an HTML page? - No
    false, // Can the <nav> element be used to create sidebar content in an HTML page? - No
    false, // Can the <textarea> element be used to draw graphics and designs in an HTML page? - No
    false, // Can the <button> element be used to create a header section in an HTML page? - No
    false, // Can the <script> element be used to create atextual paragraph in an HTML page? - No
    false, // Can the <canvas> element be used to create main headings in an HTML page? - No
    false  // Can the <footer> element be used to embed JavaScript interactions in an HTML page? - No
};
    public List<string> _Questions;
    public List<bool> _Answers;
    public TextMeshProUGUI Question_text;
    public TextMeshProUGUI[] score_text;
    public Slider slider;
    public GameObject[] slide;
    
    public int score;
    public float timer; 
    public float delay;
    public int Questions_limit;
    int Questions_number = 1;
    int random_Questions_number;
    bool correct_answer;
    float time;

    public GameObject[] cars;
    public GameObject[] baffles;
    public GameObject car;
    public GameObject cam;
    public float speed;
    public float distance;
    public Transform[] points;
    public int path;
    public float newX;

    public GameObject road;
    public float timer_road;
    public float time_road;
    public bool play;
    public LeaderboardShowcase leaderboardShowcase;

    void Start()
    {
        _Questions.AddRange(Questions);
        _Answers.AddRange(Answers);
        Question_text.text = "";

        car = cars[Random.Range(0, cars.Length)];
        car.SetActive(true);
        cam.transform.parent = car.transform;
    }

    void Update()
    {
        if (play == true)
        {
            score_text[0].text = "score:" + score;
            if (time == 0)
            {
                Question_text.text = "";
            }

            time += Time.deltaTime;
            time_road += Time.deltaTime;

            if (timer + delay <= time)
            {
                lose();
                time = 0;
            }

            if (delay < time && Question_text.text == "")
            {
                nextQuestion();
            }

            slider.value = (time - delay) / timer;

            points[0].position = new Vector3(points[0].position.x, points[0].position.y, car.transform.position.z + distance);
            points[1].position = new Vector3(points[1].position.x, points[1].position.y, car.transform.position.z + distance);
            newX = Mathf.Lerp(car.transform.position.x, points[path].transform.position.x, Time.deltaTime * 5);

            car.transform.position = new Vector3(newX, car.transform.position.y, car.transform.position.z);
            car.transform.Translate(0, 0, speed * Time.deltaTime);

            if (timer_road <= time_road)
            {
                time_road = 0;
                road.transform.position = road.transform.position + new Vector3(0, 0, 64 * 5);
                road = road.GetComponent<Road>().road;
            }

            if (Questions_limit < Questions_number)
            {
                play = false;
                ez_win();
            }
        }
    }

    public void start_play()
    {
        slide[0].SetActive(false);
        slide[1].SetActive(true);
        play = true;
    }

    public void ez_win()
    {
        slide[1].SetActive(false);
        slide[2].SetActive(true);
        score_text[1].text = "score:" + score;

        leaderboardShowcase._playerScore = score;
        leaderboardShowcase.AddPlayerScore();
        leaderboardShowcase.Submit();
     //   leaderboardShowcase.Load();
    }

    public void nextQuestion()
    {
        random_Questions_number = Random.Range(0, _Questions.Count);
        Question_text.text = Questions_number + ". " + _Questions[random_Questions_number];
        Questions_number++;
        correct_answer = _Answers[random_Questions_number];
        _Questions.RemoveAt(random_Questions_number);
        _Answers.RemoveAt(random_Questions_number);
    }

    public void yes()
    {
        if (time > delay)
        {
            if (correct_answer == true)
            {
                win();
            }
            else
            {
                lose();
            }
        }
    }

    public void no()
    {
        if (time > delay)
        {
            if (correct_answer == false)
            {
                win();
            }
            else
            {
                lose();
            }
        }
    }

    public void lose()
    {
        score -= 200;
        time = 0;

        GameObject baffles_ = Instantiate(baffles[Random.Range(0, baffles.Length)]);
        path = Random.Range(0, 2);
        baffles_.transform.position = points[path].transform.position;
    }

    public void win()
    {
        float s = 500 - (((time - delay) / timer) * 200);
        score += (int)s;
        time = 0;
        print(s);
        GameObject baffles_ = Instantiate(baffles[Random.Range(0, baffles.Length)]);
        path = Random.Range(0,2);
        baffles_.transform.position = points[path].transform.position;
        path = 1 - path;
    }

    public void play_again()
    {
        score = 0;
        time = 0;
        Questions_number = 0;
        slide[2].SetActive(false);
        slide[1].SetActive(true);
        play = true;
    }
}
