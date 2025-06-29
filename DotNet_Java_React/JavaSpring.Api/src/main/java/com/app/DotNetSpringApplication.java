package com.app;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class DotNetSpringApplication {

	public static void main(String[] args) {
		SpringApplication.run(DotNetSpringApplication.class, args);
	}

}

/*
// For Port is used 8080 then try this

netstat -aon | findstr :8080  =>  To Check Which Process Is Using Port 8080
tasklist /FI "PID eq <PID_NUMBER>" => (tasklist /FI "PID eq 6420") => Find the process using PID 6420:
taskkill /PID 6420 /F  => If you want to free up port 8080:


*/
