package com.laojike.keytool.util;

import java.util.UUID;


public class KeyUtil {
	public static String GenerateUniqueCode() {
		String uniqueCode_temp = UUID.randomUUID().toString().replace("-", "").substring(0, 8);
		String uniqueCode = "";
		for (int n = 0; n < uniqueCode_temp.length(); n++) {
			String temp = uniqueCode_temp.substring(n, n + 1);
			if (n % 2 == 0) {
				temp = temp.toLowerCase();
			}else {
				temp = temp.toUpperCase();
			}
			uniqueCode += temp;
		}

		return uniqueCode;
	}
}
