package com.app.exception;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDateTime;

@RestControllerAdvice
public class GlobalExceptionHandler {

    @ExceptionHandler(RuntimeException.class)
    public ResponseEntity<?> handleRuntimeException(RuntimeException ex) {
        ErrorResponse error = new ErrorResponse(LocalDateTime.now(), ex.getMessage(), HttpStatus.NOT_FOUND.value());
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body(error);
    }

    @ExceptionHandler(Exception.class)
    public ResponseEntity<?> handleOtherExceptions(Exception ex) {
        ErrorResponse error = new ErrorResponse(LocalDateTime.now(), "Server error: " + ex.getMessage(), HttpStatus.INTERNAL_SERVER_ERROR.value());
        return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(error);
    }

    static class ErrorResponse {
        private LocalDateTime timestamp;
        private String message;
        private int status;

        public ErrorResponse(LocalDateTime timestamp, String message, int status) {
            this.timestamp = timestamp;
            this.message = message;
            this.status = status;
        }

        public LocalDateTime getTimestamp() { return timestamp; }
        public String getMessage() { return message; }
        public int getStatus() { return status; }
    }
}
