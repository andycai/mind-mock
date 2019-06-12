using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Facade.GetInstance().RegisterObservers(new IController[] {
            new RoleController(),
        });
		Debug.LogError("=============cn Float: " + Mind.Mock.Rand.Float());
		Debug.LogError("=============cn Id: " + Mind.Mock.Rand.Id());
		Debug.LogError("=============cn Guid: " + Mind.Mock.Rand.Guid());
		Debug.LogError("=============cn Increment: " + Mind.Mock.Rand.Incr(1));
		Debug.LogError("=============cn Increment: " + Mind.Mock.Rand.Incr(1));
		Debug.LogError("=============cn Increment: " + Mind.Mock.Rand.Incr(100));
		Debug.LogError("=============cn Increment: " + Mind.Mock.Rand.Incr(1000));
		Debug.LogError("=============cn URL: " + Mind.Mock.Rand.URL());
		Debug.LogError("=============cn Protocol: " + Mind.Mock.Rand.Protocol());
		Debug.LogError("=============cn Domain: " + Mind.Mock.Rand.Domain());
		Debug.LogError("=============cn TLD: " + Mind.Mock.Rand.TLD());
		Debug.LogError("=============cn Email: " + Mind.Mock.Rand.Email());
		Debug.LogError("=============cn IP: " + Mind.Mock.Rand.IP());
		Debug.LogError("=============cn word: " + Mind.Mock.Rand.CWord());
		Debug.LogError("=============cn title: " + Mind.Mock.Rand.CTitle());
		Debug.LogError("=============cn sentence: " + Mind.Mock.Rand.CSentence());
		Debug.LogError("=============cn paragraph: " + Mind.Mock.Rand.CParagraph());
		Debug.LogError("=============word: " + Mind.Mock.Rand.Word());
		Debug.LogError("=============title: " + Mind.Mock.Rand.Title());
		Debug.LogError("=============sentence: " + Mind.Mock.Rand.Sentence());
		Debug.LogError("=============paragraph: " + Mind.Mock.Rand.Paragraph());
		var str = "";
		for (var i=0; i<50; i++)
		{
			str += Mind.Mock.Rand.Char("lower");	
		}
		Debug.LogError("=============lower: " + str);
		str = "";
		for (var i=0; i<50; i++)
		{
			str += Mind.Mock.Rand.Char("upper");	
		}
		Debug.LogError("=============upper: " + str);
		str = "";
		for (var i=0; i<50; i++)
		{
			str += Mind.Mock.Rand.Char("number");	
		}
		Debug.LogError("=============number: " + str);
		str = "";
		for (var i=0; i<50; i++)
		{
			str += Mind.Mock.Rand.Char("symbol");	
		}
		Debug.LogError("=============symbol: " + str);
		str = "";
		for (var i=0; i<50; i++)
		{
			str += Mind.Mock.Rand.Char("alpha");	
		}
		Debug.LogError("=============aplpha: " + str);

		Debug.LogError("=============ip" + Mind.Mock.Rand.IP());
		Debug.LogError("=============date time" + Mind.Mock.Rand.Datetime());
		Debug.LogError("=============region: " + Mind.Mock.Rand.Region());
		Debug.LogError("=============zip: " + Mind.Mock.Rand.Zip());
		Debug.LogError("=============province: " + Mind.Mock.Rand.Province());
		Debug.LogError("=============city: " + Mind.Mock.Rand.City());
		Debug.LogError("=============county: " + Mind.Mock.Rand.County());
		Debug.LogError("=============first name: " + Mind.Mock.Rand.FirstName());
		Debug.LogError("=============last name: " + Mind.Mock.Rand.LastName());
		Debug.LogError("=============full name: " + Mind.Mock.Rand.FullName());
		Debug.LogError("=============cn first name: " + Mind.Mock.Rand.CFirstName());
		Debug.LogError("=============cn last name: " + Mind.Mock.Rand.CLastName());
		Debug.LogError("=============cn full name: " + Mind.Mock.Rand.CFullName());
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
